using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Service.SignalR;

namespace Client.Student
{
    public partial class nextForm : Form
    {
        public nextForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignalRClient.GetInstance().goToNextQuestionOnClick(1);
        }
    }
}
