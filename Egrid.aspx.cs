using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClosedXML.Excel;
using System.IO;
public partial class Egrid : System.Web.UI.Page
{
    VehiOperation vo = new VehiOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PopulateData();
        }

    }

    void PopulateData()
    {
        grdvw.DataSource = vo.getDT("select * from t_IR");
        grdvw.DataBind();
    }

    protected void btnup_Click(object sender, EventArgs e)
    {
        int i, j;

        if (flupl.FileName != "")
        {
            flupl.SaveAs(Server.MapPath("/Excel") + flupl.FileName);

            XLWorkbook wrk = new XLWorkbook(Server.MapPath("/Excel") + flupl.FileName);

            IXLWorksheet sht = wrk.Worksheet(1);



            DataTable dt = new DataTable();

            for (j = 1; j < 20; j++)
            {
                if (sht.Cell(1, j).Value.ToString() != "")
                {
                    dt.Columns.Add(sht.Cell(1, j).Value.ToString());
                }
            }

            for (i = 2; i < 100; i++)
            {

                if (sht.Cell(i, 2).Value.ToString() != "")
                {
                    DataRow dr = dt.NewRow();

                    for (j = 0; j < dt.Columns.Count; j++)
                    {
                        dr[j] = sht.Cell(i, (j + 1)).Value;
                    }

                    dt.Rows.Add(dr);
                }
            }

            grdvw.DataSource = dt;
            grdvw.DataBind();
        }
        else
        {
            Response.Write("Please Select File");

            grdvw.DataSource = "";
            grdvw.DataBind();
        }

    }


    protected void uplddb_Click(object sender, EventArgs e)
    {
        try
        {
            VehiOperation vo = new VehiOperation();
            int i;
            if (grdvw.Rows.Count > 0)
            {
                for (i = 0; i < grdvw.Rows.Count; i++)
                {
                    String sql;
                    if (vo.getDT("select EmpID from t_excel where EmpID = '" + grdvw.Rows[i].Cells[0].Text + "'").Rows.Count == 0)
                    {
                        sql = "insert into t_excel values(";
                        sql += "'" + grdvw.Rows[i].Cells[0].Text + "',";
                        sql += "'" + grdvw.Rows[i].Cells[1].Text + "',";
                        sql += "'" + grdvw.Rows[i].Cells[2].Text + "',";
                        sql += "'" + grdvw.Rows[i].Cells[3].Text + "',";
                        sql += "'" + grdvw.Rows[i].Cells[4].Text + "')";
                    }
                    else
                    {
                        sql = "update t_excel set ";
                        sql += " Name = '" + grdvw.Rows[i].Cells[1].Text + "',";
                        sql += " Dept = '" + grdvw.Rows[i].Cells[2].Text + "',";
                        sql += " Phone = '" + grdvw.Rows[i].Cells[3].Text + "',";
                        sql += " Addrs = '" + grdvw.Rows[i].Cells[4].Text + "'";
                        sql += " where empid = '" + grdvw.Rows[i].Cells[0].Text + "'";

                    }
                    vo.getDT(sql);
                }

                Response.Write("Data uploaded in db");
            }
            else
            {
                Response.Write("First upload excel file");
            }
        }
        catch (Exception en)
        {
            Response.Write(en.Message);

            Response.Write("<br/> Please check excel format");
        }
    }

    protected void expexcl_Click(object sender, EventArgs e)
    {
        /*
        Response.Clear();
        Response.AppendHeader("content.disposition", "attachment; filename=Excelemploydtls.xls");
        Response.ContentType = "application/excel";

        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

        grdvw.RenderControl(htmlTextWriter);
        Response.Write(stringWriter.ToString());
        Response.End();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
       
    }

    */

        Response.Clear();
        Response.Buffer = true;
        Response.ContentType = "application/ms-excel";
        Response.AppendHeader("content-disposition", "attachment; filename=flupl.xls");
        Response.Charset = "";
        StringWriter sw = new StringWriter();
        HtmlTextWriter htw = new HtmlTextWriter(sw);
        grdvw.RenderControl(htw);
        Response.Output.Write(sw.ToString());
        Response.End();
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }
}