using quiztest.Core;
using quiztest.QuestionsData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quiztest
{
    public partial class MainForm : Form
    {
        public CmdState cmdState; 
        public Question Question { get; private set; } 
        private AddQuestions questionsForm; 
        private RadioButton[] radioButtons = new RadioButton[4]; 
        private DataManagement dataManagement; 
        private List<Question> questions; 
        private int[] randArr;
        private int questionNumber;
        private int rightAnswersCount;
        private TestTimer testTimer;
        private int timerMinutes = 30 * 60;

        public MainForm()
        {
            InitializeComponent();
            StartWindow sw = new StartWindow();
            sw.Close();
            Init();
        }

        private void Init()
        {
            if (!timer.Enabled)
            {
                timer.Enabled = true;
                testTimer = new TestTimer(timerMinutes, true);
            }

            confirmBtn.Enabled = false;
            questionNumber = 0;
            rightAnswersCount = 0;
            dataManagement = new DataManagement(this, "");
            questions = dataManagement.GetAllQuestions();
            cmdState = CmdState.Default;
            questionLabel.Text = questions[0].Qstn;
            randArr = Extensions.GetRandomArray(4);
            qstnNumLabel.Text = $"Вопрос №{1} из {questions.Count}";
            string[] opts = GetOptions(0);
            int radioBtnWidth = optPanel.Width;
            int radioBtnHeight = optPanel.Height / 4;

            for (int i = 0; i < radioButtons.Length; i++)
            {
                int y = i % 4; 
                radioButtons[i] = new RadioButton();
                radioButtons[i].Size = new Size(radioBtnWidth, radioBtnHeight);
                radioButtons[i].Location = new Point(10, y * radioBtnHeight);
                radioButtons[i].Font = new Font("Verdana", 14);
                radioButtons[i].Text = opts[randArr[i]];

                optPanel.Controls.Add(radioButtons[i]);
            }
        }

        public void UpdateBinding()
        {
            dataManagement = new DataManagement(this, "");
            questions = dataManagement.GetAllQuestions();
        }

        private void SwitchPage(int num)
        {
            string[] opts = GetOptions(num);
            qstnNumLabel.Text = $"Вопрос №{num + 1} из {questions.Count}";

            radioButtons[0].Text = opts[randArr[0]];
            radioButtons[1].Text = opts[randArr[1]];
            radioButtons[2].Text = opts[randArr[2]];
            radioButtons[3].Text = opts[randArr[3]];
        }

        private string[] GetOptions(int num)
        {
            PropertyInfo[] properties = questions[num].GetType().GetProperties();
            List<object> list = new List<object>();
            string[] opts = new string[4];
            randArr = Extensions.GetRandomArray(opts.Length);

            foreach (PropertyInfo p in properties)
            {
                object myVal = p.GetValue(questions[num]);
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
            string answer = questions[num].OptionA;
            foreach (RadioButton radioBtn in optPanel.Controls)
            {
                if (radioBtn.Checked && radioBtn.Text.Equals(answer))
                {
                    rightAnswersCount++;
                    break;
                }
            }
        }

        private void добавитВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmdState = CmdState.Add;
            questionsForm = new AddQuestions(this);
            questionsForm.Show();
        }

        private void изменитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataManagement = new DataManagement(null, questionLabel.Text);
            Question = dataManagement.GetQuestion();
            cmdState = CmdState.Update;
            questionsForm = new AddQuestions(this);
            questionsForm.Show();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataManagement = new DataManagement(this, questionLabel.Text);
            Question = dataManagement.GetQuestion();
            cmdState = CmdState.Delete;
            dataManagement.DeleteQuestion();

            questionNumber = (questionNumber > 0) ? questionNumber - 1 : questionNumber + 1;
            SwitchPage(questionNumber);
            UpdateBinding();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (questionNumber == questions.Count - 1)
            {
                confirmBtn.Enabled = true;
                nextBtn.Enabled = false;
                return;
            }

            CheckAnswer(questionNumber);

            questionNumber++;
            SwitchPage(questionNumber);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int lastQuestion = questions.Count;
            CheckAnswer(lastQuestion - 1);
            MessageBox.Show($"Вы дали {rightAnswersCount} правильных ответов из {lastQuestion}");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            testTimer.TimerRun();

            if (testTimer.Hours == 0 && testTimer.Minutes == 0 && testTimer.Secs == 0)
            {
                timer.Enabled = false;
                testTimer.IsRunning = false;
            }
            else
            {
                string time = String.Format("{0:00}:{1:00}:{2:00}", testTimer.Hours, testTimer.Minutes, testTimer.Secs);
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
                timerMinutes = res * 60;
                timerSetPanel.Visible = false;
            }
        }

        private void установитьТаймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerSetPanel.Visible = true;
        }
    }
}
