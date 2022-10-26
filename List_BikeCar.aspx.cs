using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class List_Vehi : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    VehiOperation vo = new VehiOperation();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            PopulateVehi();
        }
    }

    void PopulateVehi()   //for search in list
    {
        string sql = "select * from t_BikeCar";
        if (txtsrch.Text != "")
        {
            sql += " where (";
            sql += " Model like '%" + txtsrch.Text + "%'";
            sql += " or Brand1 like '%" + txtsrch.Text + "%'";
            sql += ")";
        }


        grdBicar.DataSource = vo.getDT(sql);
        grdBicar.DataBind();
    }
    protected void grdBicar_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int idx = int.Parse(e.CommandArgument.ToString());
        string BikeCar = grdBicar.Rows[idx].Cells[2].Text;
        if (e.CommandName == "del")
        {
            string sql = "delete from t_BikeCar where VehiNo = " + BikeCar;
            vo.getDT(sql);
            Response.Write("Data Has Been Deleted");
            PopulateVehi();

        }
        if (e.CommandName == "edt")
        {
            Response.Redirect("frm_BikeCar.aspx?VehiNo= " + BikeCar);
        }
    }
    protected void btnsrch_Click(object sender, EventArgs e)
    {
        PopulateVehi();
    }

}