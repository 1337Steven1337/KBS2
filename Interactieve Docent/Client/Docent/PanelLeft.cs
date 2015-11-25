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
            listBox.BorderStyle = BorderStyle.None;

            leftBottomButton.Text = "Add List";
            rightBottomButton.Text = "Delete List";

            middleRow.Controls.Add(listBox);
            LoadList();
            middleRow.Controls.Add(listBox);
            //Place the maintable in 1/3 of the panelsTable !! ALWAYS END OF CONSTUCTOR !!
            updateLayout();
            panelsTable.Controls.Add(mainTable, 0, 0);
        }

        //Load all question lists in a Listbox
        public void LoadList()
        {
            listBox.DataSource = List.getAll();
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";            
        }

        public void LoadList(int selected)
        {
            listBox.DataSource = List.getAll();
            if (selected != 0)
            {
                listBox.SelectedIndex = selected - 1;
            }
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Id";
        }

        public void AddList()
        {
            Docent.AddListPopup add = new Docent.AddListPopup();
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

            Docent.DeletePopup delete = new Docent.DeletePopup();
            delete.ShowDialog();

            if (delete.valid)
            {
                int selectedIndex = listBox.SelectedIndex;

                List list = new List();
                int id = Convert.ToInt32(listBox.SelectedValue);
                list.Id = id;
                list.delete();

                LoadList(selectedIndex);
            }
        }

        public void doubleClick(int index)
        {
            Docent.AddListPopup popup = new Docent.AddListPopup();
            popup.ShowDialog();

            if (popup.valid)
            {
                int selectedIndex = listBox.SelectedIndex;

                string name = popup.name;
                List list = new List();
                int id = Convert.ToInt32(listBox.SelectedValue);
                list.Id = id;
                list.Name = name;
                list.update();

                LoadList(selectedIndex+1);
            }
        }
    }
}
