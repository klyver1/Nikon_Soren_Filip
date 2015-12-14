using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace RepoNikon
{
    public class BrugerFac : AutoFac<Bruger>
    {
        private Mapper<Bruger> mapper = new Mapper<Bruger>();

        public Bruger Login(string email, string password)
        {
            using (
                var CMD = new SqlCommand("SELECT * FROM Bruger Where Email=@Email And Adgangskode=@ ADgangskode",
                    Conn.CreateConnection()))
            {
                CMD.Parameters.AddWithValue("@Email", email.Trim());
                CMD.Parameters.AddWithValue("@Adgangskode", password.Trim());
                var r = CMD.ExecuteReader();
                Bruger per = new Bruger();
                if (r.Read())
                {
                    per = mapper.Map(r);
                }
                r.Close();
                CMD.Connection.Close();
                return per;
            }
        }

        public bool UserExists(string email)
        {
            using (var CMD = new SqlCommand("SELECT ID FROM Bruger WHERE Email=@Email", Conn.CreateConnection()))
            {
                CMD.Parameters.AddWithValue("@Email", email);
                var r = CMD.ExecuteReader();
                if (r.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
    