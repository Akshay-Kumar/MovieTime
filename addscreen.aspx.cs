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

public partial class addscreen : System.Web.UI.Page
{
    SqlDataReader dr;
    //SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\dotnet project\\BALLE BALLE\\BALLE BALLE\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null || Session["type"] == null)
        {
            Response.Redirect("errorpage.aspx");
        }
        string sql1 = "select MAX(SUBSTRING(ScreenId,2,4)) from Screen";
        SqlCommand cmd = new SqlCommand(sql1, con1);
        con1.Open();
        dr = cmd.ExecuteReader();
        String m = null;
        while (dr.Read())
        {
            m = dr.GetValue(0).ToString();
        }
        con1.Close();

        int i = int.Parse(m);
        i = i + 1;
        TextBox1.Text = "s" + i.ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = 0;
        if (TextBox2.Text.Length == 0)
        {
            Label7.Text = "Screen name cannot be left blank";
            i++;
        }

        if (TextBox3.Text.Length == 0)
        {
            Label8.Text = "Address cannont be left blank";
            i++;
        }

        if (TextBox4.Text.Length == 0)
        {
            Label9.Text = "please enter the zone";
            i++;
        }

        if (TextBox5.Text.Length == 0)
        {
            Label10.Text = "please enter the capacity";
            i++;
        }

        


        if (i == 0)
        {
            SqlCommand cmd1 = new SqlCommand("insert into Screen(ScreenId,ScreenDetails,Addr,Zone,NOS) VALUES(@mid,@mn,@ad,@la,@ty)", con1);

            cmd1.Parameters.Add("@mid", SqlDbType.VarChar);
            cmd1.Parameters.Add("@mn", SqlDbType.VarChar);
            cmd1.Parameters.Add("@ad", SqlDbType.VarChar);
            cmd1.Parameters.Add("@la", SqlDbType.VarChar);
            cmd1.Parameters.Add("@ty", SqlDbType.VarChar);
           
            cmd1.Parameters["@mid"].Value = TextBox1.Text;
            cmd1.Parameters["@mn"].Value = TextBox2.Text;
            cmd1.Parameters["@ad"].Value = TextBox3.Text;
            cmd1.Parameters["@la"].Value = TextBox4.Text;
            cmd1.Parameters["@ty"].Value = TextBox5.Text;
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();
            Page_Load(sender, e);
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Label6.Text = " Last Screen Added Successfully enter new Screen detail";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        Label6.Text = "";
        Label7.Text = "";
        Label8.Text = "";
        Label9.Text = "";
        Label10.Text = "";
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
}
