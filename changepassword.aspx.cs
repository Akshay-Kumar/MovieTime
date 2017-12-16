using System;
using System.Collections;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
using System.Data.SqlClient;

public partial class admintask : System.Web.UI.Page
{
    SqlDataReader dr;
    //SqlConnection con1 = new SqlConnection(" Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\omb\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    //SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\dotnet project\\BALLE BALLE\\BALLE BALLE\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null || Session["type"] == null || Session["email"]==null)
        {
            Response.Redirect("errorpage.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
  
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string type = Session["type"].ToString();
        if (type == "a")
        {
            Response.Redirect("adminhome.aspx");
        }
        else
        { Response.Redirect("user.aspx"); }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
    
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
       
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        string type = Session["type"].ToString();
        if (type == "a")
        {
            Response.Redirect("adminhome.aspx");
        }
        else
        {
            Response.Redirect("user.aspx");
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        int i=0,f=0,g=0;
        string s1,s2;
        SqlDataReader dr1;
        if (TextBox4.Text.Length == 0)
        {
            Label7.Text = "Please enter the user ID";
        }
        if (TextBox1.Text.Length==0)
        {
            Label2.Text = "Please enter old password";
            i++;
        }   
          
         if (TextBox2.Text.Length == 0)
         {
             Label3.Text = "please confirm the password";
             i++;
         }
        if (TextBox3.Text.Length==0)
        {
            Label4.Text="please reconfirm the password";
            i++;
        }
        if(TextBox3.Text!=TextBox2.Text)
        {
            Label4.Text="The two passwords do not match";
            i++;
        }
        if (i == 0)
        {
            SqlCommand cmd2 = new SqlCommand("select email from username", con1);
            con1.Open();
            dr1 = cmd2.ExecuteReader();
            while (dr1.Read())
            {
                s1 = dr1.GetValue(0).ToString();
                if (s1 == TextBox4.Text.ToString())
                    f++;


            }
            con1.Close();
            SqlCommand cmd1 = new SqlCommand("select password from username", con1);
            con1.Open();
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                s2 = dr.GetValue(0).ToString();
                if (s2 == TextBox1.Text.ToString())
                    g++;

                
            }
            con1.Close();
            if (f>0 && g>0)
            {
                string sql = "update username set password='" + TextBox2.Text.ToString() + "' where email='" + TextBox4.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, con1);

                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();
                Label5.Text = "password modified";
            }
            else if (f == 0)
                Label7.Text = "Incorrect userID";
            else if (g == 0)
                Label2.Text = "Old password wrong";
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Label2.Text = "";
        Label3.Text = "";
        Label4.Text = "";
        Label5.Text = "";
        TextBox4.Text = "";
        Label7.Text = "";


    }
}
