using _07_exercise.Properties;
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
        private string saveConfigPath;
        private string lastDir;
        private string formats = "Text Files (*.txt)|*.txt|Ini Files (*.ini)|*.ini|Java Files (*.java)|*.java|C Sharp Files (*.cs)|*.cs|Python Files (*.py)|*.py|Html Files (*.html)|*.html|Css Files (*.css)|*.css|Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
        private bool needSave = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "The best Notepad";

            try
            {
                saveConfigPath = Environment.GetEnvironmentVariable("appdata") + Path.DirectorySeparatorChar + "thebestnotepad";
                if (!Directory.Exists(saveConfigPath))
                {
                    Directory.CreateDirectory(saveConfigPath);
                }
            }
            catch (IOException)
            {
                return;
            }
            catch (Exception)
            {
                return;
            }

            /*
             * Menu Events
             */
            aboutMenuItem.Click += new EventHandler((sender, e) => MessageBox.Show("App made by Gabriel ❤", "About", MessageBoxButtons.OK, MessageBoxIcon.Information));
            undoMenuItem.Click += new EventHandler((sender, e) => textBox1.Undo());
            cutMenuItem.Click += new EventHandler((sender, e) => textBox1.Cut());
            copyMenuItem.Click += new EventHandler((sender, e) => textBox1.Copy());
            pasteMenuItem.Click += new EventHandler((sender, e) => textBox1.Paste());
            selectAllMenuItem.Click += new EventHandler((sender, e) => { textBox1.SelectAll(); update_addtionalInfo(); });

            /*
             * Left Bar Buttons Events
             */
            newButton.Click += new EventHandler((sender, e) => newMenuItem.PerformClick());
            undoButton.Click += new EventHandler((sender, e) => undoMenuItem.PerformClick());
            copyButton.Click += new EventHandler((sender, e) => copyMenuItem.PerformClick());
            cutButton.Click += new EventHandler((sender, e) => cutMenuItem.PerformClick());
            pasteButton.Click += new EventHandler((sender, e) => pasteMenuItem.PerformClick());
            selectAllButton.Click += new EventHandler((sender, e) => selectAllMenuItem.PerformClick());
            textBox1.TextChanged += new EventHandler((sender, e) => { update_addtionalInfo(); needSave = true; });
            textBox1.Click += new EventHandler((sender, e) => update_addtionalInfo());

            /*
             *  Left Bar Adding Images to Buttons.
             */
            newButton.Image = new Bitmap(Resources.newDoc, new Size(26, 26));
            undoButton.Image = new Bitmap(Resources.undo, new Size(26, 26));
            cutButton.Image = new Bitmap(Resources.cut, new Size(26, 26));
            copyButton.Image = new Bitmap(Resources.copy, new Size(26, 26));
            pasteButton.Image = new Bitmap(Resources.paste, new Size(26, 26));
            selectAllButton.Image = new Bitmap(Resources.selectAll, new Size(26, 26));

            /*
             * Context Menu Events 
             */
            undoContextMenuItem.Click += new EventHandler((sender, e) => undoMenuItem.PerformClick());
            cutContextMenuItem.Click += new EventHandler((sender, e) => cutMenuItem.PerformClick());
            copyContextMenuItem.Click += new EventHandler((sender, e) => copyMenuItem.PerformClick());
            pasteContextMenuItem.Click += new EventHandler((sender, e) => pasteMenuItem.PerformClick());
            selectAllContextMenuItem.Click += new EventHandler((sender, e) => selectAllMenuItem.PerformClick());

            /*
            * Load Json file or creating new Config
            */
            load_settings();

            /*
             * Apply Settings
             */
            apply_settings();

        }

        private void load_settings()
        {
            /*
             * Loading appsettings.json into the config object
             */

            try
            {
                Debug.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
                config = new ConfigurationBuilder().SetBasePath(saveConfigPath).AddJsonFile("appsettings.json").Build().Get<Config>();
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
            /*
             * Apply Settings
             */

            wordwrapMenuItem.Checked = config.WordWrap;
            textBox1.WordWrap = wordwrapMenuItem.Checked;

            switch (config.Mode)
            {
                case 0:
                    defaultMenuItem.Checked = true;
                    break;
                case 1:
                    upperCaseMenuItem.Checked = true;
                    break;
                case 2:
                    lowerCaseMenuItem.Checked = true;
                    break;
            }
            textBox1.ForeColor = Color.FromArgb(config.FontColor);
            textBox1.BackColor = Color.FromArgb(config.BackgroundColor);
            textBox1.Font = new Font(config.Font, (float)config.FontSize, (FontStyle)config.FontSty);

            lastDir = config.LastDir;
            recentFiles = config.RecentFiles;

            refreshRecent();
        }

        private void save_settings()
        {
            /*
             * Change values
             */

            config.WordWrap = wordwrapMenuItem.Checked;

            if (defaultMenuItem.Checked)
            {
                config.Mode = 0;
            }
            else if (upperCaseMenuItem.Checked)
            {
                config.Mode = 1;
            }
            else if (lowerCaseMenuItem.Checked)
            {
                config.Mode = 2;
            }

            config.FontColor = textBox1.ForeColor.ToArgb();
            config.BackgroundColor = textBox1.BackColor.ToArgb();
            config.Font = textBox1.Font.FontFamily.Name;
            config.FontSty = (int)textBox1.Font.Style;
            config.FontSize = textBox1.Font.Size;
            config.LastDir = lastDir;
            config.RecentFiles = recentFiles;

            JsonSerializerOptions jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            /*
             * Serialize the config object
             */

            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());
            string newJson = JsonSerializer.Serialize(config, jsonWriteOptions);

            /*
             * Overwrite appsettings.json with the new JSON
             */
            string appSettingsPath = Path.Combine(saveConfigPath, "appsettings.json");
            Debug.WriteLine(appSettingsPath);

            File.WriteAllText(appSettingsPath, newJson);
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
            needSave = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
            needSave = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needSave)
            {
                switch (MessageBox.Show("Do you want save changes?", "Save", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        saveMenuItem.PerformClick();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }

            }

            save_settings();
        }

        private void newRecentFile(string path)
        {
            if (path.Trim() != "")
            {
                lastDir = path;
                recentFiles.Insert(0, path);

                if (recentFiles.Count > 5)
                {
                    recentFiles.RemoveAt(recentFiles.Count() - 1);
                }
                refreshRecent();
            }
        }

        private void refreshRecent()
        {
            ToolStripMenuItem[] tsmItems = new ToolStripMenuItem[recentFiles.Count];
            recentFilesMenuItem.DropDownItems.Clear();
            for (int i = 0; i < recentFiles.Count; i++)
            {
                tsmItems[i] = new ToolStripMenuItem();
                tsmItems[i].Text = recentFiles[i];
                tsmItems[i].Click += tsmItemClick;
            }
            recentFilesMenuItem.DropDownItems.AddRange(tsmItems);
            update_addtionalInfo();
        }
        private void tsmItemClick(object sender, EventArgs e)
        {
            Trace.WriteLine(((ToolStripMenuItem)sender).Text);
            try
            {
                textBox1.Text = File.ReadAllText(((ToolStripMenuItem)sender).Text);
                needSave = false;
            }
            catch (DirectoryNotFoundException)
            {
                Trace.WriteLine("DirectoryNotFound on tsmItemClick");
            }
            catch (Exception)
            {
                Trace.WriteLine("DirectoryNotFound on tsmItemClick");
            }
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            if (needSave)
            {
                switch (MessageBox.Show("Do you want save changes?", "Save", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        saveMenuItem.PerformClick();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            textBox1.Text = "";
            update_addtionalInfo();
            needSave = false;
        }


        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordwrapMenuItem.Checked = !wordwrapMenuItem.Checked;

            textBox1.WordWrap = wordwrapMenuItem.Checked;
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
            defaultMenuItem.Checked = false;
            upperCaseMenuItem.Checked = false;
            lowerCaseMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void writeSelection_CheckStateChanged(object sender, EventArgs e)
        {

            if (defaultMenuItem.Checked)
            {
                textBox1.CharacterCasing = CharacterCasing.Normal;
            }

            if (upperCaseMenuItem.Checked)
            {
                textBox1.CharacterCasing = CharacterCasing.Upper;
            }

            if (lowerCaseMenuItem.Checked)
            {
                textBox1.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void update_addtionalInfo()
        {
            int selectLength = textBox1.SelectionLength > 0 ? textBox1.SelectionLength : 0;
            int selectStart = textBox1.SelectionLength > 0 ? textBox1.SelectionStart : 0;


            selectionSize.Text = $"Selection size: {selectLength}";
            selection.Text = $"Selection: From {selectStart} to {selectStart + selectLength}";
            countSentences.Text = $"Sentences: {textBox1.Text.Split('.', StringSplitOptions.RemoveEmptyEntries).Length}";
            countWords.Text = $"Words: {textBox1.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length}";
            countCharacters.Text = $"Characters: {textBox1.Text.Length}";
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                update_addtionalInfo();
            }
        }

        private void Form_Key(object sender, KeyEventArgs e)
        {
            update_addtionalInfo();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}