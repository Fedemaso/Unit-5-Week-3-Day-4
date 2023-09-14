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
    public partial class SelectContatti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from RubricaContatti", conn);
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                string NomeCliente = sqlDataReader["Nome"].ToString();
                string CognomeCliente = sqlDataReader["Cognome"].ToString();
                int idContatto = Convert.ToInt32(sqlDataReader["idContatto"].ToString());

                ElencoContatti.InnerHtml += $"<p>{NomeCliente} {CognomeCliente} <a href='DettaglioContatto.aspx?idContatto={idContatto}'>Dettagli Contatto</a></p>";
            }

            conn.Close();
        }
    }
}