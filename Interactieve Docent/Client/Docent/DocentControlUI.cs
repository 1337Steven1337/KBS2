using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.API.Models;

namespace Client
{
    public partial class DocentControlUI : Form
    {
        private PanelLeft panelLeft;
        private PanelMiddle panelMiddle;
        private PanelRight panelRight;

        public DocentControlUI()
        {                   
            InitializeComponent();
            this.Load += listBox_SelectedIndexChanged;     
                   
            TableLayoutPanel panelsTable = new TableLayoutPanel();
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            panelsTable.Dock = DockStyle.Fill;
            panelsTable.ColumnCount = 3;
            panelsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            panelsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            panelsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            
            panelLeft = new PanelLeft(this, panelsTable);            
            panelMiddle = new PanelMiddle(this, panelsTable);
            panelRight = new PanelRight(this, panelsTable);
          
            panelLeft.listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;        
            panelMiddle.leftBottomButton.Click += loadAddQuestionFormHandler;
            panelRight.leftBottomButton.Click += saveQuestionHandler;

            this.Controls.Add(panelsTable);
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            panelMiddle.loadQuestionList((int)panelLeft.listBox.SelectedValue);           
        }

        private void loadAddQuestionFormHandler(object sender, System.EventArgs e)
        {
            panelRight.loadAddQuestionForm();
        }

        private void saveQuestionHandler(object sender, EventArgs e)
        {
            String question = panelRight.questionField.Text;
            int time = (int)panelRight.timeField.Value;
            int points = (int)panelRight.pointsField.Value;

            int listId = (int)panelLeft.listBox.SelectedValue;

            Question q = new Question();
            q.Text = question;
            q.List = List.getById(listId);
            q.save();

            //reload question list
            panelMiddle.loadQuestionList(listId);
        }
    }
}
