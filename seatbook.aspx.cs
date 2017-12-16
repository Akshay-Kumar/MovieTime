using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class test : System.Web.UI.Page
{
    static int capacity = 73;
    static string seat = null;
    //static string seatnumber = null;
    static int count = 0;
 

    SqlDataReader dr;
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=E:\\AMIT\\MOVIE PROJECT DOT NET\\FINAL PROJECT MOVIE TIME\\DATBASE\\WEB.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["da"]==null || Session["dt"]==null || Session["name"] == null || Session["userid"] == null || Session["email"] == null || Session["tid"] == null || Session["movname"] == null || Session["type"] == null || Session["slot"] == null || Session["screen"] == null || Session["fare"] == null || Session["date"] == null || Session["movid"]==null || Session["screenid"]==null || Session["location"]==null)
        {
            Session.Clear();
            Response.Redirect("errorpage.aspx");
        }
        else
        {

            LinkButton2.Visible = false;
            bool flag = Check();
            if (flag == false)
            {
                Label3.Text = "ALL SEATS ARE RESERVED!";
                LinkButton2.Visible = true;
            }
            else
            {

                string s = GetSeat();
                if (s != null)
                {
                    int i = 0;
                    while (i < s.Length)
                    {
                        string x = s.Substring(i, 3);
                        disable(x);
                        i = i + 4;
                    }
                }
            }
        }
    }
    public void disable(string str)
    {
        for (int i = 1; i <=13; i++)
        {
           
            if(str=="A0"+i)
            {
             int j=i+1;
             switch (j)
             {
                 case 2:
                     Button2.Enabled = false;
                     break;
                 case 3:
                     Button3.Enabled = false;
                     break;
                 case 4:
                     Button4.Enabled = false;
                     break;
                 case 5:
                     Button5.Enabled = false;
                     break;
                 case 6:
                     Button6.Enabled = false;
                     break;
                 case 7:
                     Button7.Enabled = false;
                     break;
                 case 8:
                     Button8.Enabled = false;
                     break;
                 case 9:
                     Button9.Enabled = false;
                     break;
                 case 10:
                     Button10.Enabled = false;
                     break;
                 case 11:
                     Button11.Enabled = false;
                     break;
                 case 12:
                     Button12.Enabled = false;
                     break;
                 case 13:
                     Button13.Enabled = false;
                     break;
                 case 14:
                     Button14.Enabled = false;
                     break;
             }
            }
            if (str == "B0" + i)
            {
                int j = i + 1;
                switch (j)
                {
                    case 2:
                        Button15.Enabled = false;
                        break;
                    case 3:
                        Button16.Enabled = false;
                        break;
                    case 4:
                        Button17.Enabled = false;
                        break;
                    case 5:
                        Button18.Enabled = false;
                        break;
                    case 6:
                        Button19.Enabled = false;
                        break;
                    case 7:
                        Button20.Enabled = false;
                        break;
                    case 8:
                        Button21.Enabled = false;
                        break;
                    case 9:
                        Button22.Enabled = false;
                        break;
                    case 10:
                        Button23.Enabled = false;
                        break;
                    case 11:
                        Button24.Enabled = false;
                        break;
                    case 12:
                        Button25.Enabled = false;
                        break;
                    case 13:
                        Button26.Enabled = false;
                        break;
                    case 14:
                        Button27.Enabled = false;
                        break;
                }

            }
            if (str == "C0" + i)
            {
                int j = i + 1;
                switch (j)
                {
                    case 2:
                        Button28.Enabled = false;
                        break;
                    case 3:
                        Button29.Enabled = false;
                        break;
                    case 4:
                        Button30.Enabled = false;
                        break;
                    case 5:
                        Button31.Enabled = false;
                        break;
                    case 6:
                        Button32.Enabled = false;
                        break;
                    case 7:
                        Button33.Enabled = false;
                        break;
                    case 8:
                        Button34.Enabled = false;
                        break;
                    case 9:
                        Button35.Enabled = false;
                        break;
                    case 10:
                        Button36.Enabled = false;
                        break;
                    case 11:
                        Button37.Enabled = false;
                        break;
                    case 12:
                        Button38.Enabled = false;
                        break;
                    case 13:
                        Button39.Enabled = false;
                        break;
                    case 14:
                        Button40.Enabled = false;
                        break;
                }
            }
            if (str == "D0" + i)
            {
                int j = i + 1;
                switch (j)
                {
                    case 2:
                        Button41.Enabled = false;
                        break;
                    case 3:
                        Button42.Enabled = false;
                        break;
                    case 4:
                        Button43.Enabled = false;
                        break;
                    case 5:
                        Button44.Enabled = false;
                        break;
                    case 6:
                        Button45.Enabled = false;
                        break;
                    case 7:
                        Button46.Enabled = false;
                        break;
                    case 8:
                        Button47.Enabled = false;
                        break;
                    case 9:
                        Button48.Enabled = false;
                        break;
                    case 10:
                        Button49.Enabled = false;
                        break;
                    case 11:
                        Button50.Enabled = false;
                        break;
                    case 12:
                        Button51.Enabled = false;
                        break;
                    case 13:
                        Button52.Enabled = false;
                        break;
                    case 14:
                        Button53.Enabled = false;
                        break;
                }
            }
            if (str == "E0" + i)
            {
                int j = i + 1;
                switch (j)
                {
                    case 2:
                        Button54.Enabled = false;
                        break;
                    case 3:
                        Button55.Enabled = false;
                        break;
                    case 4:
                        Button56.Enabled = false;
                        break;
                    case 5:
                        Button57.Enabled = false;
                        break;
                    case 6:
                        Button58.Enabled = false;
                        break;
                    case 7:
                        Button59.Enabled = false;
                        break;
                    case 8:
                        Button60.Enabled = false;
                        break;
                    case 9:
                        Button61.Enabled = false;
                        break;
                    case 10:
                        Button62.Enabled = false;
                        break;
                    case 11:
                        Button63.Enabled = false;
                        break;
                    case 12:
                        Button64.Enabled = false;
                        break;
                    case 13:
                        Button65.Enabled = false;
                        break;
                    case 14:
                        Button66.Enabled = false;
                        break;
                }
            }
            if (str == "F0" + i)
            {
                int j = i + 1;
                switch (j)
                {
                    case 2:
                        Button67.Enabled = false;
                        break;
                    case 3:
                        Button68.Enabled = false;
                        break;
                    case 4:
                        Button69.Enabled = false;
                        break;
                    case 5:
                        Button70.Enabled = false;
                        break;
                    case 6:
                        Button71.Enabled = false;
                        break;
                    case 7:
                        Button72.Enabled = false;
                        break;
                    case 8:
                        Button73.Enabled = false;
                        break;
                    case 9:
                        Button74.Enabled = false;
                        break;
                }
            }


        }
    }
    protected string GetSeat()
    {
        string slot = Session["slot"].ToString();
        string a = Session["tid"].ToString();
        string seatnumber = null;
        
           string scid=Session["screenid"].ToString();
           string date = Session["date"].ToString();
           string location = Session["location"].ToString();
           string movieid = Session["movid"].ToString();
            string sqln = "select sno from Transaction1 where ScreenId='"+scid+"' and slot='"+slot+"' and Dt='"+date+"' and location='"+location+"' and MovieID='"+movieid+"'";
          
            SqlCommand cmdn = new SqlCommand(sqln,con);
            con.Open();
            dr = cmdn.ExecuteReader();
            while (dr.Read())
            {
                seatnumber = seatnumber+dr.GetValue(0).ToString();
             
            }
            con.Close();
        
        return seatnumber;
    }
    protected void UpdateSeat(string s)
    {
        count = count + 1;
        capacity = capacity - 1;
        seat = seat + s + ",";
        string date = Session["date"].ToString();
        string sid = Session["screenid"].ToString();
        string tid = Session["tid"].ToString();
        string slot = Session["slot"].ToString();
        string location = Session["location"].ToString();
        string sql = "update Transaction1 set sno='" + seat + "' where TransactionID='" + tid + "' and ScreenID='"+sid+"' and slot='"+slot+"' and Dt='"+date+"' and location='"+location+"'";
       
        string sql2 = "update ScreenMovie set Capacity='"+capacity+"' where ScreenID='"+sid+"'";
        
        SqlCommand cmd = new SqlCommand(sql, con);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        SqlCommand cmd2 = new SqlCommand(sql2,con);

        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();

    }
    public bool Check()
    {
       string sid  = Session["screenid"].ToString();
       string mid = Session["movid"].ToString();
       string sql = "select Capacity from View2 where ScreenID='"+sid+"' and MovieID='"+mid+"'";
       string x = null;
       
       con.Open();
       SqlCommand cmd5 = new SqlCommand(sql,con);
       dr = cmd5.ExecuteReader();
       while (dr.Read())
       {
           x = dr.GetValue(0).ToString();
       }
       con.Close();
       int n = int.Parse(x);
       if (n <= 0)
       {

           foreach (Control c in Page.Controls)
           foreach (Control ctrl in c.Controls)
           if (ctrl is Button)
           ((Button)ctrl).Enabled = false;
           return false;
       }
       else
       {
           return true;
       }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        UpdateSeat("A01");
        Button2.Text = "RESERVED";
        Button2.Enabled = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        UpdateSeat("A02");
        Button3.Text = "RESERVED";
        Button3.Enabled = false;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        UpdateSeat("A03");
        Button4.Text = "RESERVED";
        Button4.Enabled = false;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        UpdateSeat("A04");
        Button5.Text = "RESERVED";
        Button5.Enabled = false;
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        UpdateSeat("A05");
        Button6.Text = "RESERVED";
        Button6.Enabled = false;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        UpdateSeat("A06");
        Button7.Text = "RESERVED";
        Button7.Enabled = false;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        UpdateSeat("A07");
        Button8.Text = "RESERVED";
        Button8.Enabled = false;
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        UpdateSeat("A08");
        Button9.Text = "RESERVED";
        Button9.Enabled = false;
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        UpdateSeat("A09");
        Button10.Text = "RESERVED";
        Button10.Enabled = false;
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        UpdateSeat("A10");
        Button11.Text = "RESERVED";
        Button11.Enabled = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("home.aspx");
    }
    protected void Button75_Click(object sender, EventArgs e)
    {
        int payment = count * (int.Parse(Session["fare"].ToString()));
        Session["noseat"] = count;
        Session["payment"] = payment;
        Session["seatno"] = seat;
        Response.Redirect("printpage.aspx");
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        UpdateSeat("A11");
        Button12.Text = "RESERVED";
        Button12.Enabled = false;
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        UpdateSeat("A12");
        Button13.Text = "RESERVED";
        Button13.Enabled = false;
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        UpdateSeat("A13");
        Button14.Text = "RESERVED";
        Button14.Enabled = false;
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        UpdateSeat("B01");
        Button15.Text = "RESERVED";
        Button15.Enabled = false;

    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        UpdateSeat("B02");
        Button16.Text = "RESERVED";
        Button16.Enabled = false;
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        UpdateSeat("B03");
        Button17.Text = "RESERVED";
        Button17.Enabled = false;
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        UpdateSeat("B04");
        Button18.Text = "RESERVED";
        Button18.Enabled = false;
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        UpdateSeat("B05");
        Button19.Text = "RESERVED";
        Button19.Enabled = false;
    }
    protected void Button20_Click(object sender, EventArgs e)
    {

        UpdateSeat("B06");
        Button20.Text = "RESERVED";
        Button20.Enabled = false;
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        UpdateSeat("B07");
        Button21.Text = "RESERVED";
        Button21.Enabled = false;
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        UpdateSeat("B08");
        Button22.Text = "RESERVED";
        Button22.Enabled = false;
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        UpdateSeat("B09");
        Button23.Text = "RESERVED";
        Button23.Enabled = false;
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        UpdateSeat("B10");
        Button24.Text = "RESERVED";
        Button24.Enabled = false;
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        UpdateSeat("B11");
        Button25.Text = "RESERVED";
        Button25.Enabled = false;
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        UpdateSeat("B12");
        Button26.Text = "RESERVED";
        Button26.Enabled = false;
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        UpdateSeat("B13");
        Button27.Text = "RESERVED";
        Button27.Enabled = false;
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        UpdateSeat("C01");
        Button28.Text = "RESERVED";
        Button28.Enabled = false;
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        UpdateSeat("C02");
        Button29.Text = "RESERVED";
        Button29.Enabled = false;
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        UpdateSeat("C03");
        Button30.Text = "RESERVED";
        Button30.Enabled = false;
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        UpdateSeat("C04");
        Button31.Text = "RESERVED";
        Button31.Enabled = false;
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        UpdateSeat("C05");
        Button32.Text = "RESERVED";
        Button32.Enabled = false;
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        UpdateSeat("C06");
        Button33.Text = "RESERVED";
        Button33.Enabled = false;
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        UpdateSeat("C07");
        Button34.Text = "RESERVED";
        Button34.Enabled = false;
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        UpdateSeat("C08");
        Button35.Text = "RESERVED";
        Button35.Enabled = false;

    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        UpdateSeat("C09");
        Button36.Text = "RESERVED";
        Button36.Enabled = false;
    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        UpdateSeat("C10");
        Button37.Text = "RESERVED";
        Button37.Enabled = false;
    }
    protected void Button38_Click(object sender, EventArgs e)
    {
        UpdateSeat("C11");
        Button38.Text = "RESERVED";
        Button38.Enabled = false;
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        UpdateSeat("C12");
        Button39.Text = "RESERVED";
        Button39.Enabled = false;
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        UpdateSeat("C13");
        Button40.Text = "RESERVED";
        Button40.Enabled = false;
    }
    protected void Button41_Click(object sender, EventArgs e)
    {
        UpdateSeat("D01");
        Button41.Text = "RESERVED";
        Button41.Enabled = false;
    }
    protected void Button42_Click(object sender, EventArgs e)
    {

        UpdateSeat("D02");
        Button42.Text = "RESERVED";
        Button42.Enabled = false;
    }
    protected void Button43_Click(object sender, EventArgs e)
    {

        UpdateSeat("D03");
        Button43.Text = "RESERVED";
        Button43.Enabled = false;
    }
    protected void Button44_Click(object sender, EventArgs e)
    {

        UpdateSeat("D04");
        Button44.Text = "RESERVED";
        Button44.Enabled = false;
    }
    protected void Button45_Click(object sender, EventArgs e)
    {

        UpdateSeat("D05");
        Button45.Text = "RESERVED";
        Button45.Enabled = false;
    }
    protected void Button46_Click(object sender, EventArgs e)
    {

        UpdateSeat("D06");
        Button46.Text = "RESERVED";
        Button46.Enabled = false;
    }
    protected void Button47_Click(object sender, EventArgs e)
    {

        UpdateSeat("D07");
        Button47.Text = "RESERVED";
        Button47.Enabled = false;
    }
    protected void Button48_Click(object sender, EventArgs e)
    {

        UpdateSeat("D08");
        Button48.Text = "RESERVED";
        Button48.Enabled = false;
    }
    protected void Button49_Click(object sender, EventArgs e)
    {

        UpdateSeat("D09");
        Button49.Text = "RESERVED";
        Button49.Enabled = false;
    }
    protected void Button50_Click(object sender, EventArgs e)
    {

        UpdateSeat("D10");
        Button50.Text = "RESERVED";
        Button50.Enabled = false;
    }
    protected void Button51_Click(object sender, EventArgs e)
    {
        UpdateSeat("D11");
        Button51.Text = "RESERVED";
        Button51.Enabled = false;
    }
    protected void Button52_Click(object sender, EventArgs e)
    {
        UpdateSeat("D12");
        Button52.Text = "RESERVED";
        Button52.Enabled = false;
    }
    protected void Button53_Click(object sender, EventArgs e)
    {
        UpdateSeat("D13");
        Button53.Text = "RESERVED";
        Button53.Enabled = false;
    }
    protected void Button54_Click(object sender, EventArgs e)
    {
        UpdateSeat("E01");
        Button54.Text = "RESERVED";
        Button54.Enabled = false;
    }
    protected void Button55_Click(object sender, EventArgs e)
    {
        UpdateSeat("E02");
        Button55.Text = "RESERVED";
        Button55.Enabled = false;
    }
    protected void Button56_Click(object sender, EventArgs e)
    {
        UpdateSeat("E03");
        Button56.Text = "RESERVED";
        Button56.Enabled = false;
    }
    protected void Button57_Click(object sender, EventArgs e)
    {
        UpdateSeat("E04");
        Button57.Text = "RESERVED";
        Button57.Enabled = false;
    }
    protected void Button58_Click(object sender, EventArgs e)
    {
        UpdateSeat("E05");
        Button58.Text = "RESERVED";
        Button58.Enabled = false;
    }
    protected void Button59_Click(object sender, EventArgs e)
    {
        UpdateSeat("E06");
        Button59.Text = "RESERVED";
        Button59.Enabled = false;
    }
    protected void Button60_Click(object sender, EventArgs e)
    {
        UpdateSeat("E07");
        Button60.Text = "RESERVED";
        Button60.Enabled = false;
    }
    protected void Button61_Click(object sender, EventArgs e)
    {
        UpdateSeat("E08");
        Button61.Text = "RESERVED";
        Button61.Enabled = false;
    }
    protected void Button62_Click(object sender, EventArgs e)
    {
        UpdateSeat("E09");
        Button62.Text = "RESERVED";
        Button62.Enabled = false;
    }
    protected void Button63_Click(object sender, EventArgs e)
    {
        UpdateSeat("E10");
        Button63.Text = "RESERVED";
        Button63.Enabled = false;
    }
    protected void Button64_Click(object sender, EventArgs e)
    {
        UpdateSeat("E11");
        Button64.Text = "RESERVED";
        Button64.Enabled = false;
    }
    protected void Button65_Click(object sender, EventArgs e)
    {
        UpdateSeat("E12");
        Button65.Text = "RESERVED";
        Button65.Enabled = false;
    }
    protected void Button66_Click(object sender, EventArgs e)
    {
        UpdateSeat("E13");
        Button66.Text = "RESERVED";
        Button66.Enabled = false;
    }
    protected void Button67_Click(object sender, EventArgs e)
    {
        UpdateSeat("F01");
        Button67.Text = "RESERVED";
        Button67.Enabled = false;
    }
    protected void Button68_Click(object sender, EventArgs e)
    {

        UpdateSeat("F02");
        Button68.Text = "RESERVED";
        Button68.Enabled = false;
    }
    protected void Button69_Click(object sender, EventArgs e)
    {

        UpdateSeat("F03");
        Button69.Text = "RESERVED";
        Button69.Enabled = false;
    }
    protected void Button70_Click(object sender, EventArgs e)
    {

        UpdateSeat("F04");
        Button70.Text = "RESERVED";
        Button70.Enabled = false;
    }
    protected void Button71_Click(object sender, EventArgs e)
    {

        UpdateSeat("F05");
        Button71.Text = "RESERVED";
        Button71.Enabled = false;
    }
    protected void Button72_Click(object sender, EventArgs e)
    {

        UpdateSeat("F06");
        Button72.Text = "RESERVED";
        Button72.Enabled = false;
    }
    protected void Button73_Click(object sender, EventArgs e)
    {

        UpdateSeat("F07");
        Button73.Text = "RESERVED";
        Button73.Enabled = false;
    }
    protected void Button74_Click(object sender, EventArgs e)
    {

        UpdateSeat("F08");
        Button74.Text = "RESERVED";
        Button74.Enabled = false;
    }
  
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
}
