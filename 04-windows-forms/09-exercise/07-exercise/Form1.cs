using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _07_exercise
{
    public partial class Form1 : Form
    {
        public object Properties { get; private set; }
        private Config config;

        public Form1()
        {
            InitializeComponent();
            load_settings();
        }


        private void load_settings()
        {
            //Loading appsettings.json into the config object
            try
            {
                config = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build().Get<Config>();
            }
            catch (IOException)
            {
                config = new Config();
            }
            catch (Exception)
            {
                config = new Config();
            }
        }

        private void save_settings()
        {
            //Change values
            config.AppConfig.WordWrap = true;
            config.AppConfig.Mode = 0;
            config.AppConfig.FontColor = Color.RebeccaPurple;
            config.AppConfig.BackgroundColor = Color.RebeccaPurple;
            config.AppConfig.Font = new Font("Arial", 22);
            config.AppConfig.LastDir = "";
            config.AppConfig.RecentFiles = new List<string>();

            JsonSerializerOptions jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            // Serialize the config object
            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());
            string newJson = JsonSerializer.Serialize(config, jsonWriteOptions);

            // Overwrite appsettings.json with the new JSON
            string appSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            Trace.WriteLine(appSettingsPath);
            File.WriteAllText(appSettingsPath, newJson);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Ini Files (*.ini)|*.ini|Java Files (*.java)|*.java|C Sharp Files (*.cs)|*.cs|Python Files (*.py)|*.py|Html Files (*.html)|*.html|Css Files (*.css)|*.css|Xml Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "texto|*.txt";
            saveFileDialog.ValidateNames = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter s = new StreamWriter(saveFileDialog.FileName);
                s.Write(textBox1.Text);
                s.Close();
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
    }
}