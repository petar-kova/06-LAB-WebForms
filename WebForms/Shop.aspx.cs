using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Xml.Linq;

public partial class Shop : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadGrid();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Products (Name, Description) VALUES (@n,@d)", con);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@d", txtDesc.Text);
            cmd.ExecuteNonQuery();
        }

        LoadGrid();
    }

    private void LoadGrid()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            gvProducts.DataSource = dt;
            gvProducts.DataBind();
        }
    }
}
