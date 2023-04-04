using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Backend
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection connection = new SqlConnection();
        [WebMethod]
        public void updateUserTokens(int id, int tokens)
        {
            connection.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
            var procedure = "dbo.UpdateUserTokens";

            using(SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@Tokens", tokens));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        [WebMethod]
        public void updateChallengeReward(int id)
        {
            connection.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
            var procedure = "dbo.UpdateChallengeReward";

            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id", id));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        [WebMethod]
        public void addUser(int id, string username, string password, int tokens)
        {
            connection.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
            var procedure = "dbo.InsertUser";

            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@Username", username));
                command.Parameters.Add(new SqlParameter("@Password", password));
                command.Parameters.Add(new SqlParameter("@Tokens", tokens));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        [WebMethod]
        public void addChallenge(int id, int creator, string description, int reward)
        {
            connection.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
            var procedure = "dbo.CreateChallenge";

            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id", id));
                command.Parameters.Add(new SqlParameter("@Creator", creator));
                command.Parameters.Add(new SqlParameter("@Description", description));
                command.Parameters.Add(new SqlParameter("@Reward", reward));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        [WebMethod]
        public void deleteChallenge(int id)
        {
            connection.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
            var procedure = "dbo.DeleteChallenge";

            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id", id));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        [WebMethod]
        public void addParticipant(int challengeId,int userId)
        {
            connection.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
            var procedure = "dbo.AddParticipant";

            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ChallengeId", challengeId));
                command.Parameters.Add(new SqlParameter("@UserId", userId));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            connection.Close();
        }

        [WebMethod]
        public string getUserbyCredentials(string username, string password)
        {
            string result;
            DataSet ds = new DataSet();
            using(SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users WHERE Username LIKE @username AND Password LIKE @password", con);
                da.SelectCommand.Parameters.Add("@username", SqlDbType.Text, 100).Value = username;
                da.SelectCommand.Parameters.Add("@password", SqlDbType.Text, 100).Value = password;
                da.Fill(ds, "Users");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                result = row[0].ToString() + ';' + row[1].ToString() + ';' + row[3].ToString();  
                Console.WriteLine(result);
                return result;
       
            }
        }

        [WebMethod]
        public string getUserbyId(int id)
        {
            string result;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users WHERE Id = @Id", con);
                da.SelectCommand.Parameters.Add("@Id", SqlDbType.Int, 100).Value = id;
                da.Fill(ds, "Users");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                result = row[0].ToString() + ';' + row[1].ToString() + ';' + row[3].ToString();
                Console.WriteLine(result);
                return result;

            }
        }

        [WebMethod]
        public string getHostedChallenges(int userId)
        {
            string result ;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Challenge WHERE Creator = @Creator", con);
                da.SelectCommand.Parameters.Add("@Creator", SqlDbType.Int, 100).Value = userId;
                da.Fill(ds, "Challenges");
                DataTable dt = ds.Tables[0];
                int i = 0;
                string[] aux = new string[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    aux[i] = row[0].ToString() + ';' + row[1].ToString() + ';' + row[2].ToString() + ';' + row[3].ToString();
                    i++;
                }
                result = string.Join(",", aux);
                return result;

            }
        }

        [WebMethod]
        public string getActiveChallenges(int userId)
        {
            string result;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Challenge WHERE Creator != @Creator", con);
                da.SelectCommand.Parameters.Add("@Creator", SqlDbType.Int, 100).Value = userId;
                da.Fill(ds, "Challenges");
                DataTable dt = ds.Tables[0];
                int i = 0;
                string[] aux = new string[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    aux[i] = row[0].ToString() + ';' + row[1].ToString() + ';' + row[2].ToString() + ';' + row[3].ToString();
                    i++;
                }
                result = string.Join(",", aux);
                return result;

            }
        }

        [WebMethod]
        public int getMaxChallengeId()
        {
            int result;
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=desktop-6qfn9qv;Initial Catalog=Quests;Integrated Security=true";
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Id) FROM Challenge", con);
                da.Fill(ds, "Challenges");
                DataTable dt = ds.Tables[0];
                DataRow row = dt.Rows[0];
                result = int.Parse(row[0].ToString());
                return result;

            }
        }
    }
}
