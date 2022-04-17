using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace quiztest.QuestionsData
{
    class DataManagement
    {
        private const string connName = "QuizTestDB";
        private const string tableName = "QuestionsTable";

        public List<Question> GetAllQuestions()
        {
            using (IDbConnection conn = new SQLiteConnection(Helper.GetConString(connName)))
            {
                string sqlCommand = $"SELECT * FROM {tableName}";
                var result = conn.Query<Question>(sqlCommand, new DynamicParameters());
                return result.ToList();
            }
        }

        public Question GetSingleQuestion(Question question)
        {
            using (IDbConnection conn = new SQLiteConnection(Helper.GetConString(connName)))
            {
                string sqlCommand = $"SELECT * FROM {tableName} WHERE QuestionId = {question.QuestionId}";
                var result = conn.QuerySingle<Question>(sqlCommand);
                return result;
            }
        }

        public void InsertQuestion(Question question)
        {
            using (IDbConnection conn = new SQLiteConnection(Helper.GetConString(connName)))
            {
                string sqlCommand = $"INSERT INTO {tableName} (Qstn, OptionA, OptionB, OptionC, OptionD) " +
                    $"VALUES (@Qstn, @OptionA, @OptionB, @OptionC, @OptionD)";

                conn.Execute(sqlCommand, question);
                MessageBox.Show("Успешно сохранено!");
            }
        }
        
        public void UpdateQuestion(Question question)
        {
            using (IDbConnection conn = new SQLiteConnection(Helper.GetConString(connName)))
            {
                string sqlCommand = $"UPDATE {tableName} " +
                    $"SET Qstn = @Qstn, OptionA = @OptionA, OptionB = @OptionB, OptionC = @OptionC, OptionD = @sOptionD " +
                    $"WHERE QuestionId = ${question.QuestionId}";

                conn.Execute(sqlCommand, question);
                MessageBox.Show("Успешно изменено!");
            }
        }

        /*public void DeleteQuestion()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (mainForm.cmdState == CmdState.Delete)
                {
                    sqlCmd = new SQLiteCommand("DeleteQuestion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@QuestionId", mainForm.Question.QuestionId);
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
        }*//*public void DeleteQuestion()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (mainForm.cmdState == CmdState.Delete)
                {
                    sqlCmd = new SQLiteCommand("DeleteQuestion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@QuestionId", mainForm.Question.QuestionId);
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
        }*//*public void DeleteQuestion()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                if (mainForm.cmdState == CmdState.Delete)
                {
                    sqlCmd = new SQLiteCommand("DeleteQuestion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@QuestionId", mainForm.Question.QuestionId);
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
        }*/

    }
}
