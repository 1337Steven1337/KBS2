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
        private TableLayoutPanel threeColTable;
        private ListBox listBoxQuestionLists;
        private CustomPanel customPanelQuestionList;
        private QuestionListFactory factory = new QuestionListFactory();
        private QuestionController questionController;
        public BindingList<QuestionList> QuestionLists = new BindingList<QuestionList>();

        public QuestionListController(IQuestionListView view, TableLayoutPanel threeColTable, QuestionController questionController)
        {
            this.threeColTable = threeColTable;
            this.listBoxQuestionLists = view.getListBox();
            this.customPanelQuestionList = view.getCustomPanel();
            this.view = view;
            this.view.setController(this);
            this.questionController = questionController;

            customPanelQuestionList.middleRow.Controls.Add(listBoxQuestionLists);
            customPanelQuestionList.title.Text = "VragenLijsten";

            customPanel.leftBottomButton.Text = "Nieuwe lijst";
            customPanel.leftBottomButton.Click += new System.EventHandler(newList);
            customPanel.rightBottomButton.Text = "Verwijder lijst";
            customPanel.rightBottomButton.Click += new System.EventHandler(deleteList);

            threeColTable.Controls.Add(customPanel.getPanel(), 0, 0);
            mainTable.Controls.Add(threeColTable, 1, 0);

            loadLists();
            listBoxQuestionLists.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBoxQuestionLists.PreviewKeyDown += new PreviewKeyDownEventHandler(Delete_keyDown);
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
                factory.save(ql, this.view.getListBox(), processAdd);
            }
        }



        public void deleteList(object sender, EventArgs e)
        {
            ViewDeleteList dlg = new ViewDeleteList();
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.setText(listBoxQuestionLists.SelectedItem.ToString());
            dlg.ShowDialog();

            if (dlg.valid)
            {
                int id = (int)listBoxQuestionLists.SelectedValue;
                QuestionList ql = new QuestionList();
                ql.Id = id;
                factory.delete(ql, this.view.getListBox(), processDelete);
            }
        }

        private void processAdd(QuestionList ql)
        {
            this.QuestionLists.Add(ql);
        }

        private void processDelete(QuestionList ql)
        {
            int i;
            for (i = 0;  i < this.QuestionLists.Count; i++)
            {
                if(this.QuestionLists[i].Id == ql.Id)
                {
                    break;
                }
            }

            this.QuestionLists.RemoveAt(i);
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

        private void Delete_keyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteList(sender, e);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            questionController.loadQuestions((int)listBoxQuestionLists.SelectedValue);
        }
    }
}
