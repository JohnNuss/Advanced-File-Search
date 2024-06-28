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
    public partial class Search_Title_Row : UserControl
    {
        public TextBox tbBrowseLabel = new TextBox();
        public TextBox tbFolderLabel = new TextBox();
        public TextBox tbIncludeExcludeLabel = new TextBox();
        public Search_Title_Row(Rectangle location)
        {
            InitializeComponent();
            BackColor = Color.LightCyan;
            Top = location.Top;
            Left = location.Left;
            Width= location.Width;
            Height= location.Height;

            tbBrowseLabel.BorderStyle = BorderStyle.FixedSingle;
            tbBrowseLabel.Text = "Browse";
            tbBrowseLabel.Font = MainForm.DisplayFont;
            tbBrowseLabel.Top = location.Top;
            tbBrowseLabel.Left = location.Left;
            tbBrowseLabel.Width = MainForm.OpenBrowserWidth;
            tbBrowseLabel.TextAlign = HorizontalAlignment.Center;

            MainForm.FolderLeft = tbBrowseLabel.Right + MainForm.SpaceBetweenControls;
            tbFolderLabel.BorderStyle = BorderStyle.FixedSingle;
            tbFolderLabel.Text = "Folder";
            tbFolderLabel.Font = MainForm.DisplayFont;  
            tbFolderLabel.Top = location.Top;
            tbFolderLabel.Left = MainForm.FolderLeft;
            tbFolderLabel.Width = MainForm.FolderNameWidth;
            tbFolderLabel.TextAlign = HorizontalAlignment.Center;

            MainForm.IncludeExcludeLeft = tbFolderLabel.Right + MainForm.SpaceBetweenControls;
            tbIncludeExcludeLabel.BorderStyle = BorderStyle.FixedSingle;
            tbIncludeExcludeLabel.Text = "Action";
            tbIncludeExcludeLabel.Font = MainForm.DisplayFont;
            tbIncludeExcludeLabel.Left = MainForm.IncludeExcludeLeft;
            tbIncludeExcludeLabel.Width= MainForm.IncludeExcludeWidth;
            tbIncludeExcludeLabel.Top = location.Top;
            tbIncludeExcludeLabel.TextAlign= HorizontalAlignment.Center;

            tbBrowseLabel.Parent = this;
            tbFolderLabel.Parent = this;
            tbIncludeExcludeLabel.Parent = this;

        }
    }
}
