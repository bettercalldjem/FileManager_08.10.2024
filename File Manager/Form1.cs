using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDirectory(Directory.GetCurrentDirectory());
        }

        private void LoadDirectory(string path)
        {
            listBoxFiles.Items.Clear();
            try
            {
                var directories = Directory.GetDirectories(path);
                var files = Directory.GetFiles(path);
                foreach (var dir in directories)
                    listBoxFiles.Items.Add(Path.GetFileName(dir));
                foreach (var file in files)
                    listBoxFiles.Items.Add(Path.GetFileName(file));
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нет доступа к этому каталогу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                string selectedItem = listBoxFiles.SelectedItem.ToString();
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), selectedItem);
                if (Directory.Exists(fullPath))
                {
                    LoadDirectory(fullPath);
                }
                else
                {
                    if (IsTextFile(fullPath))
                    {
                        string content = File.ReadAllText(fullPath);
                        ShowFileContent(selectedItem, content);
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(fullPath);
                    }
                }
            }
        }

        private bool IsTextFile(string path)
        {
            var textFileExtensions = new[] { ".txt", ".csv", ".log", ".md" }; return textFileExtensions.Contains(Path.GetExtension(path).ToLower());
        }

        private void ShowFileContent(string fileName, string content)
        {
            Form contentForm = new Form();
            contentForm.Text = fileName;
            contentForm.Size = new System.Drawing.Size(600, 400);

            TextBox textBox = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Text = content
            };

            contentForm.Controls.Add(textBox);
            contentForm.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text;
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var results = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.AllDirectories)
                    .Where(f => f.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                if (results.Any())
                {
                    MessageBox.Show(string.Join(Environment.NewLine, results), "Результаты поиска");
                }
                else
                {
                    MessageBox.Show("Файлы не найдены.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDirectory(Directory.GetCurrentDirectory());
        }
    }
}
