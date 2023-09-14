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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (FileUpload1.HasFile)
            {
                fileName = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath($"/Content/img/{FileUpload1.FileName}"));
            }


            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO RUBRICACONTATTI VALUES(@Nome, @Cognome, @Indirizzo, @Email, @NumeroTelefono, @Foto)";
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Cognome", txtCognome.Text);
                cmd.Parameters.AddWithValue("Indirizzo", txtIndirizzo.Text);
                cmd.Parameters.AddWithValue("Email", txtIndirizzo.Text);
                cmd.Parameters.AddWithValue("NumeroTelefono", txtIndirizzo.Text);
                cmd.Parameters.AddWithValue("Foto", fileName);

                int inserimentoEffettuato = cmd.ExecuteNonQuery();

                if (inserimentoEffettuato > 0)
                {
                    Response.Write("Inserimento effettuato con successo");
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Repeater.aspx?IdContatto={Request.QueryString["IdContatto"]}");
        }
    }
}