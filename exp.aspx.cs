using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClosedXML.Excel;
using System.Data;
public partial class exp : System.Web.UI.Page
{
    VehiOperation db = new VehiOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) { }
    }



    protected void btnshow_Click(object sender, EventArgs e)
    {
        grdv.DataSource = db.getDT("select * from t_excel");
        grdv.DataBind();
    }

    protected void btnexp_Click(object sender, EventArgs e)
    {
        DataTable dt = db.getDT("select * from t_excel");

        int i;
        XLWorkbook wrk = new XLWorkbook(Server.MapPath("input/iformat.xlsx"));

        IXLWorksheet sht = wrk.Worksheet(1);
        
            for (i = 0; i < dt.Rows.Count; i++)
        {
            sht.Cell((i + 2), 1).Value = dt.Rows[i].ItemArray[0].ToString();   //for emp id
            sht.Cell((i + 2), 2).Value = dt.Rows[i].ItemArray[1].ToString();   // for emp name
            sht.Cell((i + 2), 3).Value = dt.Rows[i].ItemArray[2].ToString();   // for department
            sht.Cell((i + 2), 4).Value = dt.Rows[i].ItemArray[3].ToString();   // for phone
            sht.Cell((i + 2), 5).Value = dt.Rows[i].ItemArray[4].ToString();   // for address
        } 
             

        wrk.SaveAs(Server.MapPath("output/oformat.xlsx"));

        Response.Redirect("output/oformat.xlsx");

    }

    protected void btngrd_Click(object sender, EventArgs e)
    {
        int i;
        XLWorkbook wrk = new XLWorkbook(Server.MapPath("input/iformat.xlsx"));

        IXLWorksheet sht = wrk.Worksheet(1);
        //DataTable dt = db.getDT("select * from t_excel");

      //  for (i = 0; i < dt.Rows.Count; i++)
            if (grdv.Rows.Count > 0)
        {
            for (i = 0; i < grdv.Rows.Count; i++)
            {
                /* String sql;
                 if (db.getDT("select empid from t_excel where empid = '" + grdv.Rows[i].Cells[0].Text + "'").Rows.Count == 0)
                 {
                     sql = "insert into t_excel values(";
                     sql += "'" + grdv.Rows[i].Cells[0].Text + "',";
                     sql += "'" + grdv.Rows[i].Cells[1].Text + "',";
                     sql += "'" + grdv.Rows[i].Cells[2].Text + "',";
                     sql += "'" + grdv.Rows[i].Cells[3].Text + "',";
                     sql += "'" + grdv.Rows[i].Cells[4].Text + "')";
                 }
                 else                                                 ye sql table mai data insert karne k leye hai....
                 {
                     sql = "update t_excel set ";
                     sql += " Name = '" + grdv.Rows[i].Cells[1].Text + "',";
                     sql += " Dept = '" + grdv.Rows[i].Cells[2].Text + "',";
                     sql += " Phone = '" + grdv.Rows[i].Cells[3].Text + "',";
                     sql += " Addrs = '" + grdv.Rows[i].Cells[4].Text + "'";
                     sql += " where empid = '" + grdv.Rows[i].Cells[0].Text + "'";

                 }
                 db.getDT(sql);*/


                sht.Cell((i + 2), 1).Value = grdv.Rows[i].Cells[0].Text;   //for emp id
                sht.Cell((i + 2), 2).Value = grdv.Rows[i].Cells[1].Text;   // for emp name
                sht.Cell((i + 2), 3).Value = grdv.Rows[i].Cells[2].Text;   // for department
                sht.Cell((i + 2), 4).Value = grdv.Rows[i].Cells[3].Text;   // for phone
                sht.Cell((i + 2), 5).Value = grdv.Rows[i].Cells[4].Text;   // for address


            }

            wrk.SaveAs(Server.MapPath("output/oformat.xlsx"));

                Response.Redirect("output/oformat.xlsx");
            }
        else
        {
            Response.Write("First upload excel file");
        }
    }

    protected void grdv_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}