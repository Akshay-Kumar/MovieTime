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

public partial class home : System.Web.UI.Page
{
    //string mov = "Data Source=.\\SQLEXPRESS;AttachDbFilename=G:\\Documents and Settings\\AKKI\\Desktop\\amit\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");

    protected void Button1_Click(object sender, EventArgs e)
    {
        string u = TextBox1.Text;
        string p = TextBox2.Text;
        string t = null;
        string uid = null;
        string mail = null;
        SqlCommand cmd1 = new SqlCommand("select user_id,type,email,password from username",con1);
        SqlDataReader dr;
        bool Flag = false;
        con1.Open();
        dr = cmd1.ExecuteReader();

        while (dr.Read())
        {
            if (u == dr.GetValue(2).ToString() && p == dr.GetValue(3).ToString())
            {
                Flag = true;
                uid = dr.GetValue(0).ToString();
                t = dr.GetValue(1).ToString();
                mail = dr.GetValue(2).ToString();
                Session["email"] = mail;
                Session["userid"] = uid;
                Session["type"] = t;
                break;
            }
        }
        con1.Close();
        
        if (Flag == true)
        {
            if (t == "a")
            {
                Response.Redirect("adminhome.aspx");
            }

            if (t == "u")
            {
                Response.Redirect("user.aspx");
            }
        }
        
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("signup.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
}
