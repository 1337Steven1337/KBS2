using Client.Factory;
using Client.View.QuestionList;
using System.Windows.Forms;
using Client.View.Question;
using Client.Model;
using Client.View.PanelLayout;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Client.Controller
{
    public class QuestionListController
    {
        private IQuestionListView view;
        private TableLayoutPanel mainTable, threeColTable;
        private ListBox listBoxQuestionLists;
        private CustomPanel customPanel;
        private QuestionListFactory factory = new QuestionListFactory();
        private QuestionController questionController;
        public BindingList<QuestionList> QuestionLists = new BindingList<QuestionList>();

        public QuestionListController(IQuestionListView view, TableLayoutPanel mainTable, TableLayoutPanel threeColTable, QuestionController questionController)
        {
            this.mainTable = mainTable;
            this.threeColTable = threeColTable;
            this.listBoxQuestionLists = view.getListBox();
            this.customPanel = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);
            this.questionController = questionController;

            customPanel.middleRow.Controls.Add(listBoxQuestionLists);
            customPanel.title.Text = "VragenLijsten";

            customPanel.leftBottomButton.Text = "Nieuwe lijst";
            customPanel.leftBottomButton.Click += new System.EventHandler(newList);
            customPanel.rightBottomButton.Text = "Verwijder lijst";
            customPanel.rightBottomButton.Click += new System.EventHandler(deleteList);

            threeColTable.Controls.Add(customPanel.getPanel(), 0, 0);
            mainTable.Controls.Add(threeColTable, 1, 0);

            loadLists();
            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }

        public void newList(object sender, EventArgs e)
        {
            ViewNewQuestionList dlg = new ViewNewQuestionList();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();
            
            if (dlg.valid)
            {
                string name = dlg.text;
                QuestionList ql = new QuestionList();
                ql.Name = name;
                factory.save(ql, this.view.getListBox(), process);
            }
        }

        public void deleteList(object sender, EventArgs e)
        {
            ViewDeleteList dlg = new ViewDeleteList();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.ShowDialog();

            if (dlg.valid)
            {
                int id = (int)listBoxQuestionLists.SelectedValue;
                QuestionList ql = new QuestionList();
                ql.Id = id;
                factory.delete(ql, this.view.getListBox(), process);
            }
        }

        private void process(QuestionList ql)
        {
            this.QuestionLists.Add(ql);
        }

        private void loadLists()
        {
            factory.findAll(mainTable, this.fillList);
        }

        private void fillList(List<QuestionList> lists)
        {
            foreach(QuestionList q in lists)
            {
                this.QuestionLists.Add(q);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            questionController.loadQuestions((int)listBoxQuestionLists.SelectedValue);
        }
    }
}
