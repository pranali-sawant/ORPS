using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using QRCoder;
using System.IO;
using System.Drawing;
public partial class History : System.Web.UI.Page
{
    string strConnString = ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString;
    string str;
    SqlCommand com;
    SqlConnection fare = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\orps\\orps1\\App_Data\\reg.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cos = new SqlConnection(strConnString);
        cos.Open();
        str = "select * from register where Username='" + Session["Username"] + "'";
        com = new SqlCommand(str, cos);
        SqlDataAdapter da = new SqlDataAdapter(com);
        SqlDataReader rdr = com.ExecuteReader();
        rdr.Read();
        Label3.Text = rdr["Name"].ToString();
        Label5.Text = rdr["ID"].ToString();
        rdr.Close();
        cos.Close();
        cos.Open();
        str = "select * from passdetail where Name='" + Label3.Text + "'";
        com = new SqlCommand(str, cos);
        SqlDataAdapter san = new SqlDataAdapter(com);
        SqlDataReader ds = com.ExecuteReader();
        ds.Read();
        Label7.Text = ds["SOURCE"].ToString();
        Label9.Text = ds["DESTINATION"].ToString();
        Label11.Text = ds["VIA"].ToString();
        Label15.Text = ds["FARE"].ToString();
        Label19.Text = ds["EXP"].ToString();
        Label13.Text = ds["CLASS"].ToString();
        Label17.Text = ds["PERIOD"].ToString();
        ds.Close();
        cos.Close();
        string code = Label5.Text;
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeGenerator.QRCode qrCode = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
        System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
        imgBarCode.Height = 100;
        imgBarCode.Width = 100;
        using (Bitmap bitMap = qrCode.GetGraphic(20))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
            }
            PlaceHolder1.Controls.Add(imgBarCode);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}