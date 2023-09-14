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
    public partial class DettaglioContatto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("select * from RubricaContatti where IdContatto=@id", conn);
                cmd.Parameters.AddWithValue("id", Request.QueryString["IdContatto"]);
                SqlDataReader sqlDataReader;

                conn.Open();
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string NomeCliente = sqlDataReader["Nome"].ToString();
                    string CognomeCliente = sqlDataReader["Cognome"].ToString();
                    string IndirizzoCliente = sqlDataReader["Indirizzo"].ToString();
                    string EmailCliente = sqlDataReader["Email"].ToString();
                    string NumeroTelefono = sqlDataReader["NumeroTelefono"].ToString();
                    




                    txtNome.Text = NomeCliente;
                    txtCognome.Text = CognomeCliente;
                    txtIndirizzo.Text = IndirizzoCliente;
                    txtEmail.Text = EmailCliente;
                    txtNumeroTelefono.Text = NumeroTelefono;
                }

                conn.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE RubricaContatti SET Nome=@Nome, Cognome=@Cognome, Indirizzo=@Indirizzo where IdContatto=@id";
            cmd.Parameters.AddWithValue("Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("Cognome", txtCognome.Text);
            cmd.Parameters.AddWithValue("Indirizzo", txtIndirizzo.Text);
            cmd.Parameters.AddWithValue("Id", Request.QueryString["IdContatto"]);



            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
            Response.Redirect($"DettaglioContatto.aspx?IdContatto={Request.QueryString["IdContatto"]}");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM RubricaContatti where idContatto=@id";
            cmd.Parameters.AddWithValue("Id", Request.QueryString["IdContatto"]);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
            Response.Redirect($"SelectContatti.aspx");
        }
    }
}