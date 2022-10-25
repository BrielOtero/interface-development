using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace _07_exercise
{
    public partial class Form1 : Form
    {
        public object Properties { get; private set; }
        private Config config;
        private List<string> recentFiles;
        private string lastDir;
        private string formats = "Text Files (*.txt)|*.txt|Ini Files (*.ini)|*.ini|Java Files (*.java)|*.java|C Sharp Files (*.cs)|*.cs|Python Files (*.py)|*.py|Html Files (*.html)|*.html|Css Files (*.css)|*.css|Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
            load_settings();
            apply_settings();
        }

        private void load_settings()
        {
            //Loading appsettings.json into the config object
            try
            {
                Debug.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
                config = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build().Get<Config>();

            }
            catch (IOException)
            {
                Debug.WriteLine("IOException");
                config = new Config();
            }
            catch (Exception)
            {
                Debug.WriteLine("Exception");
                config = new Config();
            }
        }

        private void apply_settings()
        {

            wordwrapToolStripMenuItem.Checked = config.WordWrap;

            switch (config.Mode)
            {
                case 0:
                    defaultToolStripMenuItem.Checked = true;
                    break;
                case 1:
                    upperCaseToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    lowerCaseToolStripMenuItem.Checked = true;
                    break;
            }

            textBox1.ForeColor = config.FontColor;
            textBox1.BackColor = config.BackgroundColor;
            textBox1.Font = config.Font;
            Debug.WriteLine(textBox1.Font);
            lastDir = config.LastDir;
            recentFiles = config.RecentFiles;

            refreshRecent();
        }

        private void save_settings()
        {
            //Change values
            config.WordWrap = wordwrapToolStripMenuItem.Checked;

            if (defaultToolStripMenuItem.Checked)
            {
                config.Mode = 0;
            }
            else if (upperCaseToolStripMenuItem.Checked)
            {
                config.Mode = 1;
            }
            else if (lowerCaseToolStripMenuItem.Checked)
            {
                config.Mode = 2;
            }

            config.FontColor = textBox1.ForeColor;
            config.BackgroundColor = textBox1.BackColor;
            config.Font = textBox1.Font;
            config.LastDir = lastDir;
            config.RecentFiles = recentFiles;

            JsonSerializerOptions jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            // Serialize the config object
            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());
            string newJson = JsonSerializer.Serialize(config, jsonWriteOptions);

            // Overwrite appsettings.json with the new JSON
            string appSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            Debug.WriteLine(appSettingsPath);

            File.WriteAllText(appSettingsPath, newJson);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = formats;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
            newRecentFile(openFileDialog.FileName);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = formats;
            saveFileDialog.ValidateNames = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter s = new StreamWriter(saveFileDialog.FileName);
                s.Write(textBox1.Text);
                s.Close();
            }
            newRecentFile(saveFileDialog.FileName);
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Undo();

        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();

        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            save_settings();
        }

        private void newRecentFile(string path)
        {
            lastDir = path;
            recentFiles.Insert(0, path);

            if (recentFiles.Count > 5)
            {
                recentFiles.RemoveAt(recentFiles.Count() - 1);
            }
            refreshRecent();
        }

        private void refreshRecent()
        {
            ToolStripMenuItem[] tsmItems = new ToolStripMenuItem[recentFiles.Count];
            recentFilesToolStripMenuItem1.DropDownItems.Clear();
            for (int i = 0; i < recentFiles.Count; i++)
            {
                tsmItems[i] = new ToolStripMenuItem();
                tsmItems[i].Text = recentFiles[i];
                tsmItems[i].Click += tsmItemClick;
            }
            recentFilesToolStripMenuItem1.DropDownItems.AddRange(tsmItems);
        }
        private void tsmItemClick(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(((ToolStripMenuItem)sender).Text);
        }

        private void checkIsSaved()
        {
            //textBox1.is
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordwrapToolStripMenuItem.Checked = !wordwrapToolStripMenuItem.Checked;

            textBox1.WordWrap = wordwrapToolStripMenuItem.Checked;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Color = textBox1.ForeColor;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config = new Config();
            apply_settings();
        }

        private void writeSelection_Click(object sender, EventArgs e)
        {
            defaultToolStripMenuItem.Checked = false;
            upperCaseToolStripMenuItem.Checked = false;
            lowerCaseToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void writeSelection_CheckStateChanged(object sender, EventArgs e)
        {

            if (defaultToolStripMenuItem.Checked)
            {
                textBox1.CharacterCasing = CharacterCasing.Normal;
            }

            if (upperCaseToolStripMenuItem.Checked)
            {
                textBox1.CharacterCasing = CharacterCasing.Upper;
            }

            if (lowerCaseToolStripMenuItem.Checked)
            {
                textBox1.CharacterCasing = CharacterCasing.Lower;
            }
        }
    }
}