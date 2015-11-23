using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.API.Models;

namespace Client
{
    
    class PanelLeft : PanelLayout
    {
        public ListBox listBox;

        public PanelLeft(Form mainForm, TableLayoutPanel panelsTable) : base(mainForm)
        {
            title.Text = "VragenLijsten";
            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            leftBottomButton.Text = "Add List";
            rightBottomButton.Text = "Delete List";

            middleRow.Controls.Add(listBox);
            LoadList();
            
            //Place the maintable in 1/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 0, 0);
        }

        public void LoadList()
        {
            listBox.DataSource = List.getAll();
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";            
        }

        public void AddList()
        {
            Docent.AddList add = new Docent.AddList();
            add.ShowDialog();

            if (add.valid)
            {
                List list = new List();
                list.Name = add.name;
                list.save();

                LoadList();
            }
        }

        public void DeleteList()
        {
            Docent.DeleteList delete = new Docent.DeleteList();
            delete.ShowDialog();

            if (delete.valid)
            {
                List list = new List();
                int id = Convert.ToInt32(listBox.SelectedValue);
                list.Id = id;
                list.delete();

                LoadList();
            }
        }
    }
}
