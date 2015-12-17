using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.OpenQuestion
{
    public partial class ListOpenQuestionView : Form
    {
        public ListOpenQuestionView()
        {
            InitializeComponent();

            dataGridView1.Enabled = false;

            BindingList<KeyValuePair<String, String>> list = new BindingList<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("Piet", "Pizza"));
            list.Add(new KeyValuePair<string, string>("Henk", "Shoarma met saus"));
            
            dataGridView1.DataSource = list;
            dataGridView1.TabStop = false;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
            dataGridView1.Columns[0].HeaderText = "Student";
            dataGridView1.Columns[1].HeaderText = "Antwoord";
            

            list.Add(new KeyValuePair<string, string>("Gekke Freek", "Een klein beetje kruidenboter flink uitgesmeerd op een half doorbakken sneetje stokbrood"));
            
            dataGridView1.CurrentCell = null;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        public void SetText(string text)
        {
            labelText.Text = text;
        }
    }
}
