using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RepoNikon
{
    public class loginFac:AutoFac<Bruger>
    {
        public Bruger Login(string email, string password)
        {
            using (var CMD = new SqlCommand("SELECT * FROM Bruger WHERE Email=@Email AND Kodeord =@Kodeord", Conn.CreateConnection()))
            {
                CMD.Parameters.AddWithValue("@Email", email);
                CMD.Parameters.AddWithValue("@Kodeord", password);

                Mapper<Bruger> mapper = new Mapper<Bruger>();

                var r = CMD.ExecuteReader();
                Bruger bruger = new Bruger();

                if (r.Read())
                {
                    bruger = mapper.Map(r);
                }
                r.Close();
                CMD.Connection.Close();
                return bruger;
            }
        }
    }
}
