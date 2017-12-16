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

public partial class assignmovie : System.Web.UI.Page
{

//    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\omb\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
   // SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\koushik\\Desktop\\project\\New folder\\omb\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
      //SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=G:\\Documents and Settings\\AKKI\\Desktop\\amit\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null || Session["type"] == null)
        {
            Response.Redirect("errorpage.aspx");
        }

        if (!IsPostBack)
        {
            
            SqlCommand cmd1 = new SqlCommand("select DISTINCT  ScreenId from Screen", con1);
            SqlDataReader dr;
            con1.Open();
            dr = cmd1.ExecuteReader();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select");
            while (dr.Read())
            {
                String s = dr.GetValue(0).ToString();
                DropDownList1.Items.Add(s);
            }
            con1.Close();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            SqlCommand cmd1 = new SqlCommand("insert into ScreenMovie(ScreenID,MovieID,Slot,Charges,Dt) values(@sid,@mov,@slo,@ch,@dt)", con1);
            GridViewRow r;
            r = GridView1.Rows[i];
            Label l1 = (Label)r.FindControl("Label1");
            DropDownList d = (DropDownList)r.FindControl("dropdownlist2");
            TextBox t = (TextBox)r.FindControl("textbox1");
            DropDownList d1 = (DropDownList)r.FindControl("dropdownlist3");
            cmd1.Parameters.Add("@sid", SqlDbType.VarChar);
            cmd1.Parameters.Add("@mov", SqlDbType.VarChar);
            cmd1.Parameters.Add("@slo", SqlDbType.VarChar);
            cmd1.Parameters.Add("@ch", SqlDbType.VarChar);
            cmd1.Parameters.Add("@dt", SqlDbType.VarChar);
            cmd1.Parameters["@sid"].Value = DropDownList1.SelectedItem.ToString();
            cmd1.Parameters["@mov"].Value = d.Text;
            cmd1.Parameters["@slo"].Value = l1.Text;
            cmd1.Parameters["@ch"].Value = t.Text;
            cmd1.Parameters["@dt"].Value = d1.Text;
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();
            Label3.Text = "Movie assigned";


                


        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
}
