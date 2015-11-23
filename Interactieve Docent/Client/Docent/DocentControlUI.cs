﻿using System;
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

            panelLeft.leftBottomButton.Click += AddList_Click;
            panelLeft.rightBottomButton.Click += DeleteList_Click;
            panelLeft.listBox.PreviewKeyDown += new PreviewKeyDownEventHandler(leftListBox_keyDown);

            panelMiddle.rightBottomButton.Click += DeleteQuestion_Click;
            panelMiddle.listBox.PreviewKeyDown += new PreviewKeyDownEventHandler(middleListBox_keyDown);

            this.Controls.Add(panelsTable);
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            panelMiddle.loadQuestionList((int)panelLeft.listBox.SelectedValue);
        }

        private void AddList_Click(object sender, EventArgs e)
        {
            panelLeft.AddList();
        }

        private void DeleteList_Click(object sender, EventArgs e)
        {
            panelLeft.DeleteList();
        }

        private void DeleteQuestion_Click(object sender, EventArgs e)
        {
            panelMiddle.deleteQuestion();
        }

        private void leftListBox_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                panelLeft.DeleteList();
            }
        }
        private void middleListBox_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                panelMiddle.deleteQuestion();
            }
        }
    }
}
