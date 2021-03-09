using quiztest.QuestionsData;
using System;
using System.Windows.Forms;

namespace quiztest
{
    public partial class AddQuestions : Form
    {
        private MainForm mainForm;

        public AddQuestions(MainForm mainForm)
        {
            this.mainForm = mainForm;
            Init();
        }

        private void Init()
        {
            InitializeComponent();
            switch (mainForm.cmdState)
            {
                case CmdState.Add:
                    okBtn.Text = "Добавить";
                    break;
                case CmdState.Update:
                    okBtn.Text = "Изменить"; EditState();
                    break;
            }
        }

        private void EditState()
        {
            questionTB.Text = mainForm.Question.Qstn;
            optATB.Text = mainForm.Question.OptionA;
            optBTB.Text = mainForm.Question.OptionB;
            optCTB.Text = mainForm.Question.OptionC;
            optDTB.Text = mainForm.Question.OptionD;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DataManagement dataManagement = new DataManagement(mainForm, "");

            if (!String.IsNullOrEmpty(questionTB.Text) && !String.IsNullOrEmpty(optATB.Text) &&
                !String.IsNullOrEmpty(optBTB.Text) && !String.IsNullOrEmpty(optCTB.Text) &&
                !String.IsNullOrEmpty(optDTB.Text))
            {
                dataManagement.InsertorUpdateData(questionTB.Text, optATB.Text, optBTB.Text, optCTB.Text, optDTB.Text);
                ClearTextBoxes();
            }
            else
            {
                errorsLabel.Text = "Все поля должны быть заполнены!";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainForm.UpdateBinding();
            this.Close();
        }

        private void ClearTextBoxes()
        {
            questionTB.Text = optATB.Text = optBTB.Text = optCTB.Text = optDTB.Text = String.Empty;
        }

    }
}
