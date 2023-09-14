using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RubricaTelefonica
{
    public partial class Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from RubricaContatti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Contatti> listaContatti = new List<Contatti>();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Contatti contatti = new Contatti();
                contatti.IdContatto = Convert.ToInt32(sqlDataReader["idContatto"]);
                contatti.Nome = sqlDataReader["Nome"].ToString();
                contatti.Cognome = sqlDataReader["Cognome"].ToString();
                contatti.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                contatti.Foto = sqlDataReader["Foto"].ToString();
                listaContatti.Add(contatti);

            }
            Repeater1.DataSource = listaContatti;
            Repeater1.DataBind();

            

            conn.Close();
        }
    }

    public class Contatti
    {
        public int IdContatto { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Foto { get; set; }
    }
}
