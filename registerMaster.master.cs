using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

public partial class registerMaster : System.Web.UI.MasterPage
{
    public SqlConnection sad = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Pranali\\Desktop\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from register where username='" + nm.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User Already Exist");
            }
            conn.Close();
        } 
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       try
        {
           Guid newGUID = Guid.NewGuid();
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
           conn.Open();
           string insertQuery = "insert into register(ID,Name,Username,Contact,Email,Password) values(@ID,@name,@uname,@cont,@email,@pass)";
           SqlCommand com = new SqlCommand(insertQuery, conn);
           com.Parameters.AddWithValue("@ID", newGUID.ToString());
           com.Parameters.AddWithValue("@name",nm.Text);
           com.Parameters.AddWithValue("@uname",un.Text);
           com.Parameters.AddWithValue("@cont",co.Text);
           com.Parameters.AddWithValue("@email", em.Text);
           com.Parameters.AddWithValue("@pass", ps.Text);
           com.ExecuteNonQuery();
           Response.Redirect("login.aspx");
           conn.Close();
           ClearTextBox();

        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.ToString());
        }
    }
    private void ClearTextBox()
    {
        nm.Text = "";
        un.Text = "";
        co.Text = "";
        em.Text = "";
        ps.Text = "";
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand com;
        string str;
        sad.Open();
        str="select * from AADHAR where NUMBER='"+adh.Text+"'";
        com=new SqlCommand(str,sad);
        SqlDataReader reader = com.ExecuteReader();
        if (reader.Read())
        {
            nm.Text = reader["NAME"].ToString();
            co.Text = reader["CONTACT"].ToString();
            reader.Close();
            Label8.Text = "SUCCCESS";
            sad.Close();
        }
        else
        {
            Label8.Text = "FAILED";

        }
    }
}