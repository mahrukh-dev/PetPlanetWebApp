using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPlanetWebApp.Shared
{
    public class DBHelpPetService
    {

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9MFCUJA\\MAH;Initial Catalog=petplanet;Integrated Security=True");
            return con;
        }
    }
}
