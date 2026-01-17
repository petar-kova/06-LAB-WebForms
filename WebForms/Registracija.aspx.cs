using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registracija : System.Web.UI.Page
{
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            // Provjera da li postoji korisnik
            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE UserName=@u", con);
            checkCmd.Parameters.AddWithValue("@u", txtUsername.Text);

            int exists = (int)checkCmd.ExecuteScalar();
            if (exists > 0)
            {
                lblMsg.Text = "Korisničko ime već postoji!";
                return;
            }

            // Spremanje korisnika
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Users (UserName, Password, FullName) VALUES (@u,@p,@f)", con);
            cmd.Parameters.AddWithValue("@u", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);
            cmd.Parameters.AddWithValue("@f", txtFullName.Text);

            cmd.ExecuteNonQuery();
        }

        Response.Redirect("Login.aspx"); // Preusmjeri na login
    }
}
