using System.Data.SqlClient;

namespace PetPlanetWebApp.Server.Controllers
{
    public class DBHelpPet
    {

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9MFCUJA\\MAH;Initial Catalog=petplanet;Integrated Security=True");
            return con;
        }
    }
}
