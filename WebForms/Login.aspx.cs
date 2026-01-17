using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);
            cmd.Parameters.AddWithValue("@u", txtUsername.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);

            int result = (int)cmd.ExecuteScalar();

            if (result == 1)
            {
                Response.Redirect("Shop.aspx");
            }
            else
            {
                lblMsg.Text = "Neispravni podaci!";
            }
        }
    }
}
