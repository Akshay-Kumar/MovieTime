﻿using System;
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

public partial class updatescreen : System.Web.UI.Page
{
    //SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\dotnet project\\BALLE BALLE\\BALLE BALLE\\web.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlConnection con1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    SqlDataAdapter da;
    SqlCommandBuilder cb;
     DataSet ds;
    protected void LoadData()
    {
        da = new SqlDataAdapter("select ScreenId,ScreenDetails,Addr,Zone,NOS from Screen", con1);
        ds = new DataSet();
        da.Fill(ds,"scree");
        cb = new SqlCommandBuilder(da);
    }
    protected void GetData()
    {
        DataTable dt = ds.Tables[0];
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (dt.Rows[i][0].ToString() == DropDownList1.SelectedItem.ToString() || dt.Rows[i][1].ToString() == DropDownList2.SelectedItem.ToString())
            {
                TextBox1.Text = dt.Rows[i][0].ToString();
                TextBox2.Text = dt.Rows[i][1].ToString();
                TextBox3.Text = dt.Rows[i][2].ToString();
                TextBox4.Text = dt.Rows[i][3].ToString();
                TextBox5.Text = dt.Rows[i][4].ToString();
            }

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null || Session["type"] == null)
        {
            Response.Redirect("errorpage.aspx");
        }

        if (!IsPostBack)
        {

            SqlCommand cmd1 = new SqlCommand("select DISTINCT ScreenId from Screen", con1);
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
            SqlCommand cmd2 = new SqlCommand("select DISTINCT ScreenDetails from Screen", con1);
            SqlDataReader dr1;
            con1.Open();
            dr1 = cmd2.ExecuteReader();
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Select");
            while (dr1.Read())
            {
                String s1 = dr1.GetValue(0).ToString();
                DropDownList2.Items.Add(s1);
            }
            con1.Close();

        }
    }
    
   
    
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        LoadData();
        GetData();

    }
    protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
    {
        LoadData();
        GetData();
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        Label10.Text = "";
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        int i = 0;
        if (DropDownList1.SelectedIndex == 0 && DropDownList2.SelectedIndex == 0)
        {
            Label4.Text = "please select either screen name or screen Id";
            i++;
        }

        if (i == 0)
        {
            LoadData();
            DataTable dt1 = ds.Tables[0];
            for (int j = 0; j < dt1.Rows.Count; j++)
            {
                if (dt1.Rows[j][0].ToString() == DropDownList1.SelectedItem.ToString() || dt1.Rows[j][1].ToString() == DropDownList2.SelectedItem.ToString())
                {
                   // dt1.Rows[j][0] = TextBox1.Text;
                    dt1.Rows[j][1] = TextBox2.Text;
                    dt1.Rows[j][2] = TextBox3.Text;
                    dt1.Rows[j][3] = TextBox4.Text;
                    dt1.Rows[j][4] = TextBox5.Text;
                    da.Update(dt1);
                    Label10.Text = " Last Screen Updated Successfully";

                }
            }


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

