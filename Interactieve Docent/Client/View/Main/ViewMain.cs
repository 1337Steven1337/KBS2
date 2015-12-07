using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;

namespace Client.View.Main
{
    public partial class ViewMain : Form, IViewMain
    {
        private MainController controller;

        public ViewMain()
        {
            InitializeComponent();
        }

        public void setController(MainController controller)
        {
            this.controller = controller;
        }


    }
}
