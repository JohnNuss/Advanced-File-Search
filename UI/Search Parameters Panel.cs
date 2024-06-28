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
    public partial class Search_Parameters_Panel : UserControl
    {
        public List<Folder_Row> FolderRows = new List<Folder_Row>();
        public Button btnAddFolderRow = new Button();

        int addButtonTop = 0;   
        public Search_Parameters_Panel()
        {
            InitializeComponent();
            Top = MainForm.SearchTitle.Bottom + MainForm.VerticalSpacing;
            Width = MainForm.SearchTitle.Width;
            Left = MainForm.SearchTitle.Left;
            BackColor = Color.LightCyan;

            PlaceAddButton();
            btnAddFolderRow.Click += BtnAddFolderRow_Click;
        }

        private void BtnAddFolderRow_Click(object sender, EventArgs e)
        {
            
            FolderRows.Add(new Folder_Row());
            this.Controls.Clear();
            for(int idx=0; idx<FolderRows.Count; idx++) 
            {
                int top = 5 + idx * Folder_Row.RowHeight;
                Folder_Row folderRow = FolderRows[idx];
                folderRow.Top = top;
                Controls.Add(folderRow);
            }
            PlaceAddButton();
        }

        public void AddFolderRow()
        {
            FolderRows.Add(new Folder_Row());
        }

        public void RemoveFolderRow() { }

        public void PlaceAddButton()
        {
            int addButtonTop = Folder_Row.RowHeight * FolderRows.Count + MainForm.FirstTop;
            btnAddFolderRow.Top= addButtonTop;
            btnAddFolderRow.Left = MainForm.FirstLeft;
            btnAddFolderRow.Height = Folder_Row.ControlHeight;
            btnAddFolderRow.Width = MainForm.SearchTitle.Width - 20;
            btnAddFolderRow.Font = MainForm.DisplayFont;
            btnAddFolderRow.Text = "Add Search Parameter";

            btnAddFolderRow.BackColor = Color.LightSteelBlue;
            this.Controls.Add(btnAddFolderRow);
            Height = btnAddFolderRow.Bottom + MainForm.VerticalSpacing;
            
        }
    }
}
