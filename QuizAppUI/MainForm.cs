using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DataLayer.Data;
using DataLayer.QuestionsData;
using QuizAppUI.Core;

namespace QuizAppUI
{
    public partial class MainForm : Form
    {
        private AddQuestions _questionsForm; 
        private RadioButton[] radioButtons = new RadioButton[4]; 
        private DataManagement _data = new DataManagement(); 
        private List<Question> _questions;
        private string[] _rightAnswers;
        private int[] _randArr;
        private int _questionNumber = 0;
        private int _rightAnswersCount = 0;
        private CustomTimer _customTimer;
        private int _timerMinutes = 30 * 60;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            if (!timer.Enabled)
            {
                timer.Enabled = true;
                _customTimer = new CustomTimer(_timerMinutes, true);
            }

            _questions = _data.GetAllQuestions();
            _rightAnswers = _questions.Select(q => q.OptionA).ToArray();

            if (_questions.Count > 0)
            {
                questionLabel.Text = _questions.First().Qstn;
                _randArr = Extensions.GetRandomArray(4);
                qstnNumLabel.Text = $"Вопрос №{1} из {_questions.Count}";
                string[] opts = GetOptions(0);
                int radioBtnWidth = optPanel.Width;
                int radioBtnHeight = optPanel.Height / 4;

                for (int i = 0; i < radioButtons.Length; i++)
                {
                    int y = i % 4;

                    radioButtons[i] = new RadioButton
                    {
                        Size = new Size(radioBtnWidth, radioBtnHeight),
                        Location = new Point(10, y * radioBtnHeight),
                        Font = new Font("Verdana", 14),
                        Text = opts[_randArr[i]]
                    };

                    optPanel.Controls.Add(radioButtons[i]);
                }
            }
            else
            {
                MessageBox.Show("Пока нет тестов!");
            }
        }

        private void добавитВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _questionsForm = new AddQuestions(null);
            this.Hide();
            _questionsForm.Show();
        }

        private void изменитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _questionsForm = new AddQuestions(_questions[_questionNumber]);
            this.Hide();
            _questionsForm.Show();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*dataManagement = new DataManagement(this, questionLabel.Text);
            Question = dataManagement.GetQuestion(questions[questionNumber]);
            cmdState = CmdState.Delete;
            dataManagement.DeleteQuestion();

            questionNumber = (questionNumber > 0) ? questionNumber - 1 : questionNumber + 1;

            SwitchPage(questionNumber);
            UpdateBinding();*/
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            CheckAnswer(_questionNumber);

            _questionNumber++;

            SwitchPage(_questionNumber);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            CheckAnswer(_questionNumber);

            _questionNumber--;

            SwitchPage(_questionNumber);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int lastQuestion = _questions.Count;
            CheckAnswer(lastQuestion - 1);
            MessageBox.Show($"Вы дали {_rightAnswersCount} правильных ответов из {lastQuestion}");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _customTimer.TimerRun();

            if (_customTimer.Hours == 0 && _customTimer.Minutes == 0 && _customTimer.Secs == 0)
            {
                timer.Enabled = false;
                _customTimer.IsRunning = false;
            }
            else
            {
                string time = String.Format("{0:00}:{1:00}:{2:00}", _customTimer.Hours, _customTimer.Minutes, _customTimer.Secs);
                timerLabel.Text = time;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setTimerBtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(timerTB.Text, out int res))
            {
                _timerMinutes = res * 60;
                timerSetPanel.Visible = false;
            }
        }

        private void установитьТаймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerSetPanel.Visible = true;
        }

        private void SwitchPage(int num)
        {
            string[] opts = GetOptions(num);
            qstnNumLabel.Text = $"Вопрос №{num + 1} из {_questions.Count}";

            foreach (RadioButton radio in radioButtons)
            {
                if (radio.Checked)
                {
                    radio.Checked = false;
                }
            }

            radioButtons[0].Text = opts[_randArr[0]];
            radioButtons[1].Text = opts[_randArr[1]];
            radioButtons[2].Text = opts[_randArr[2]];
            radioButtons[3].Text = opts[_randArr[3]];
        }

        private string[] GetOptions(int num)
        {
            PropertyInfo[] properties = _questions[num].GetType().GetProperties();
            List<object> list = new List<object>();
            string[] opts = new string[4];
            _randArr = Extensions.GetRandomArray(opts.Length);

            foreach (PropertyInfo p in properties)
            {
                object myVal = p.GetValue(_questions[num]);
                list.Add(myVal);
            }

            questionLabel.Text = (string)list[1];

            for (int i = 2; i < list.Count; i++)
            {
                opts[i - 2] = (string)list[i];
            }

            return opts;
        }

        private void CheckAnswer(int num)
        {
            string answer = _questions[num].OptionA;

            foreach (RadioButton radioBtn in optPanel.Controls)
            {
                if (radioBtn.Checked && radioBtn.Text.Equals(answer))
                {
                    _rightAnswersCount++;
                    break;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartWindow sw = (StartWindow)Application.OpenForms["StartWindow"];
            if (sw != null)
            {
                sw.Close();
            }

            AddQuestions questionsForm = (AddQuestions)Application.OpenForms["AddQuestions"];
            if (questionsForm != null)
            {
                questionsForm.Close();
            }
        }

        private void timerValidator_Tick(object sender, EventArgs e)
        {
            if (_questionNumber == _questions.Count - 1)
            {
                prevBtn.Enabled = true;
                confirmBtn.Enabled = true;
                nextBtn.Enabled = false;
            } 
            else if (_questionNumber > 0 && _questionNumber < _questions.Count - 1)
            {
                prevBtn.Enabled = true;
                confirmBtn.Enabled = false;
                nextBtn.Enabled = true;
            }
            else if (_questionNumber == 0)
            {
                prevBtn.Enabled = false;
                confirmBtn.Enabled = false;
                nextBtn.Enabled = true;
            }
        }
    }
}
