using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quiztest.QuestionsData
{
    class DataManagement
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private string question;
        private MainForm mainForm;

        public DataManagement(MainForm mainForm, string qstn)
        {
            this.mainForm = mainForm;
            question = qstn;
            sqlCon = new SqlConnection(Helper.GetConString("QuizTestDB"));
        }

        /*public DataManagement(string qstn)
        {
            question = qstn;
            sqlCon = new SqlConnection(Helper.GetConString("QuizTestDB"));
        }*/

        public void InsertorUpdateData(string qstn, string optA, string optB, string optC, string optD)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (mainForm.cmdState == CmdState.Add)
                {
                    sqlCmd = new SqlCommand("AddOrEditQuestions", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@QuestionId", 0);
                    sqlCmd.Parameters.AddWithValue("@Question", qstn.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionA", optA.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionB", optB.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionC", optC.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionD", optD.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully!");
                }
                else if (mainForm.cmdState == CmdState.Update)
                {
                    sqlCmd = new SqlCommand("AddOrEditQuestions", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@QuestionId", mainForm.Question.Id);
                    sqlCmd.Parameters.AddWithValue("@Question", qstn.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionA", optA.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionB", optB.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionC", optC.Trim());
                    sqlCmd.Parameters.AddWithValue("@OptionD", optD.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        public Question GetQuestion()
        {
            Question qstn = new Question();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                sqlCmd = new SqlCommand("SearchQuestion", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Question", question.Trim());
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    qstn.Id = Convert.ToInt32(reader[0]);
                    qstn.Qstn = reader[1].ToString();
                    qstn.OptionA = reader[2].ToString();
                    qstn.OptionB = reader[3].ToString();
                    qstn.OptionC = reader[4].ToString();
                    qstn.OptionD = reader[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }

            return qstn;
        }

        public List<Question> GetAllQuestions()
        {
            List<Question> list = new List<Question>();
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                sqlCmd = new SqlCommand("SelectAllQuestions", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    Question qstn = new Question();
                    qstn.Id = Convert.ToInt32(reader[0]);
                    qstn.Qstn = reader[1].ToString();
                    qstn.OptionA = reader[2].ToString();
                    qstn.OptionB = reader[3].ToString();
                    qstn.OptionC = reader[4].ToString();
                    qstn.OptionD = reader[5].ToString();

                    list.Add(qstn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }

            return list;
        }

        public void DeleteQuestion()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (mainForm.cmdState == CmdState.Delete)
                {
                    sqlCmd = new SqlCommand("DeleteQuestion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@QuestionId", mainForm.Question.Id);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Removed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }
        }

    }

    public enum CmdState { Default, Add, Update, Delete }
}
