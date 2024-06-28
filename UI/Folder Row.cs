using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_File_Search.UI
{
    public partial class Folder_Row : UserControl
    {

        public Button OpenBrowser = new Button();
        public TextBox FolderName = new TextBox();
        public ComboBox IncludeExclude = new ComboBox();

        public const int RowHeight = 60;
        public const int ControlHeight = RowHeight - 20;
        public Folder_Row()
        {
            InitializeComponent();

            Left = 10;
            Width = MainForm.SearchTitle.Width;

            BackColor = Color.AliceBlue;
            Color controlBackColor = Color.White;


            OpenBrowser.Top = MainForm.FirstTop;
            OpenBrowser.Left = 0;
            OpenBrowser.Width = MainForm.OpenBrowserWidth;
            OpenBrowser.Height = ControlHeight;
            OpenBrowser.BackColor = controlBackColor;
            OpenBrowser.BackgroundImage = global::Advanced_File_Search.Properties.Resources.FolderBrowse;
            OpenBrowser.BackgroundImageLayout = ImageLayout.Stretch;




            FolderName.Top = OpenBrowser.Top + 5;
            FolderName.Left = OpenBrowser.Right + 10;
            FolderName.Width = MainForm.SearchTitle.tbFolderLabel.Width;
            FolderName.Font = MainForm.DisplayFont;
            FolderName.BackColor = controlBackColor;
            FolderName.Text = @"C:\";

            IncludeExclude.Top = OpenBrowser.Top + 5;
            IncludeExclude.Width = MainForm.SearchTitle.tbIncludeExcludeLabel.Width;
            IncludeExclude.Left = FolderName.Right + MainForm.SpaceBetweenControls;

            IncludeExclude.Height = FolderName.Height;
            IncludeExclude.BackColor = controlBackColor;
            IncludeExclude.Text = "Include";
            IncludeExclude.Font = MainForm.DisplayFont;
            IncludeExclude.Items.Add("Include");
            IncludeExclude.Items.Add("Exclude");

            Height = RowHeight;
            OpenBrowser.Parent = this;
            FolderName.Parent = this;
            IncludeExclude.Parent = this;
        }
    }
}
