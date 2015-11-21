using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.API;

namespace Client
{
    public partial class Form2 : Form
    {
        public event EventHandler SelectedIndexChanged;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            List<List> lijst = List.getAll();
            foreach (List vragenlijst in lijst)
            {
                listBox1.Items.Add(vragenlijst.Id + ": " + vragenlijst.Name);
                //Console.WriteLine(vragenlijst.Id + "\t" + vragenlijst.Name);
                //foreach (Question vraag in vragenlijst.Questions)
                //{
                //    Console.WriteLine("\t" + vraag.Id + "\t" + vraag.Text + "\t");
                //}

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int selected = listBox1.SelectedIndex;
            Console.WriteLine(listBox1.SelectedItem + "q");
        }
    }
}
