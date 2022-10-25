using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_exercise
{
    public class Config
    {
        private bool debugEnabled;
        private bool wordWrap;
        private int mode;
        private Color fontColor;
        private Color backgroundColor;
        private Font font;
        private string lastDir;
        private List<string> recentFiles;

        public bool DebugEnabled { get => debugEnabled; set => debugEnabled = value; }
        public bool WordWrap { get => wordWrap; set => wordWrap = value; }
        public int Mode { get => mode; set => mode = value; }
        public Color FontColor { get => fontColor; set => fontColor = value; }
        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public Font Font { get => font; set => font = value; }
        public string LastDir { get => lastDir; set => lastDir = value; }
        public List<string> RecentFiles { get => recentFiles; set => recentFiles = value; }

        public Config()
        {
            DebugEnabled = true;
            WordWrap = false;
            Mode = 0;
            FontColor = Color.Black;
            BackgroundColor = Color.Bisque;
            Font = new Font("Arial", 22);
            LastDir = "";
            RecentFiles = new List<string>();
        }
    }



}
