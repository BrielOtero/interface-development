using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_exercise
{
    public class Config
    {
  
        private bool wordWrap;
        private int mode;
        private int fontColor;
        private int backgroundColor;
        private String font;
        private int fontSty;
        private double fontSize;
        private string lastDir;
        private List<string> recentFiles;

        public bool WordWrap { get => wordWrap; set => wordWrap = value; }
        public int Mode { get => mode; set => mode = value; }
        public int FontColor { get => fontColor; set => fontColor = value; }
        public int BackgroundColor { get => backgroundColor; set => backgroundColor = value; }
        public String Font { get => font; set => font = value; }
        public int FontSty { get => fontSty; set => fontSty = value; }
        public double FontSize { get => fontSize; set => fontSize = value; }
        public string LastDir { get => lastDir; set => lastDir = value; }
        public List<string> RecentFiles { get => recentFiles; set => recentFiles = value; }


        public Config()
        {
            WordWrap = false;
            Mode = 0;
            FontColor = Color.Black.ToArgb();
            BackgroundColor = Color.White.ToArgb();
            Font = "Segoe UI";
            FontSty = (int)FontStyle.Regular;
            FontSize = 9;
            LastDir = "";
            RecentFiles = new List<string>();
        }
    }



}
