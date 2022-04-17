using System;
using quiztest.QuestionsData;
using System.Windows.Forms;

namespace quiztest
{
    public partial class AddQuestions : Form
    {
        private DataManagement _data;
        private Question _question;

        public AddQuestions(Question question)
        {
            InitializeComponent();
            _data = new DataManagement();
            _question = question;

            if (_question is null)
            {
                questionTB.Text = String.Empty;
                optATB.Text = String.Empty;
                optBTB.Text = String.Empty;
                optCTB.Text = String.Empty;
                optDTB.Text = String.Empty;
            }
            else
            {
                questionTB.Text = _question.Qstn;
                optATB.Text = _question.OptionA;
                optBTB.Text = _question.OptionB;
                optCTB.Text = _question.OptionC;
                optDTB.Text = _question.OptionD;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(questionTB.Text) && !String.IsNullOrEmpty(optATB.Text) &&
                !String.IsNullOrEmpty(optBTB.Text) && !String.IsNullOrEmpty(optCTB.Text) &&
                !String.IsNullOrEmpty(optDTB.Text))
            {
                if (_question is null)
                {
                    _data.InsertQuestion(new Question
                    {
                        Qstn = questionTB.Text.Trim(),
                        OptionA = optATB.Text.Trim(),
                        OptionB = optBTB.Text.Trim(),
                        OptionC = optCTB.Text.Trim(),
                        OptionD = optDTB.Text.Trim()
                    });
                } 
                else 
                {
                    _question.Qstn = questionTB.Text.Trim();
                    _question.OptionA = optATB.Text.Trim();
                    _question.OptionB = optATB.Text.Trim();
                    _question.OptionC = optCTB.Text.Trim();
                    _question.OptionD = optDTB.Text.Trim();
                    _data.UpdateQuestion(_question);
                }

                ClearTextBoxes();
            }
            else
            {
                errorsLabel.Text = "Все поля должны быть заполнены!";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void ClearTextBoxes()
        {
            questionTB.Text = optATB.Text = optBTB.Text = optCTB.Text = optDTB.Text = String.Empty;
        }
    }
}
