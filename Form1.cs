using Advanced_File_Search.UI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Advanced_File_Search
{
    public partial class MainForm : Form
    {
        public static Search_Title_Row SearchTitle;
        public Search_Parameters_Panel SearchParameters;

        public static Font DisplayFont = new Font("Calibri", 12);

        public const int OpenBrowserWidth = 60;
        public static int FolderLeft = 0;
        public static int IncludeExcludeLeft = 0;
        public const int FirstTop = 5;
        public const int FirstLeft = 10;
        public const int SpaceBetweenControls = 10;
        public const int SearchPanelWidth = 600;
        public const int FolderRowWidth = SearchPanelWidth - FirstLeft * 2;
        public const int TitlePanelHeight = 40;
        public const int VerticalSpacing = 10;

        public const int IncludeExcludeWidth = 100;
        public static int FolderNameWidth = FolderRowWidth - OpenBrowserWidth - IncludeExcludeWidth - 20;
        public MainForm()
        {
            InitializeComponent();

            Text = "Advanced File Search";
            Rectangle SearchTitleLocation = new Rectangle(
                FirstLeft, FirstTop, SearchPanelWidth, TitlePanelHeight);
            SearchTitle = new Search_Title_Row(SearchTitleLocation);
            SearchTitle.Parent= this;

            SearchParameters= new Search_Parameters_Panel();
            SearchParameters.Parent = this;
        }
    }
}
