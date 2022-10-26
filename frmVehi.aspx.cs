using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class frmVehi : System.Web.UI.Page
{
    VehiOperation vo = new VehiOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataTable dt = vo.getDT("Select '' as Brand union Select Brand from t_ola");
            txtBrand1.DataSource = dt;
            txtBrand1.DataTextField = "Brand";
            txtBrand1.DataBind();

            txtBrand2.DataSource = dt;
            txtBrand2.DataTextField = "Brand";
            txtBrand2.DataBind();


            DataTable det = vo.getDT("Select '' as EngineType union Select EngineType from t_engine");
            txtEngineType.DataSource = det;
            txtEngineType.DataTextField = "EngineType";
            txtEngineType.DataBind();



            if (Request.QueryString["VehiNo"] != null)
            {
                txtVehiNo.Text = Request.QueryString["VehiNo"].ToString();
                DataSearch();
            }

        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string sql = "";
        if (txtVehiNo.Text == "")
        {
            string id = vo.getDT("select isnull (max(VehiNo),1412)+1010 from t_BikeCar").Rows[0].ItemArray[0].ToString();

            txtVehiNo.Text = id;

            sql = " insert into t_BikeCar values (";
            sql += "'" + id + "',";
            sql += "'" + txtModel.Text + "',";
            sql += "'" + txtBrand1.Text + "',";
            sql += "'" + txtBrand2.Text + "',";
            sql += "'" + txtEngineType.Text + "',";
            sql += "'" + txtPerson.Text + "',";
            sql += "'" + txtAmount.Text + "',";
            sql += "'" + txtqty.Text + "')";
        }
        else
        {

            sql = "update t_BikeCar set ";
            sql += "Model = '" + txtModel.Text + "',";
            sql += "Brand1 = '" + txtBrand1.Text + "',";
            sql += "Brand2 = '" + txtBrand2.Text + "',";
            sql += "EngineType = '" + txtEngineType.Text + "',";
            sql += "Person = '" + txtPerson.Text + "',";

            sql += "Quantity = '" + txtqty.Text + "',";

            sql += "Amount = '" + txtAmount.Text + "'";

            sql += " where VehiNo = '" + txtVehiNo.Text + "'";
        }

        vo.getDT(sql);

        int tq = int.Parse(txtqty.Text);
        for (int i = 1; i <= tq; i++)
        {
            string id = vo.getDT("select isnull(max(StockID),1010)+ 11 from t_vehi_stock").Rows[0].ItemArray[0].ToString();

            sql = "insert into t_vehi_stock(StockID,VehiNo,Model,VehiStatus) values (";
            sql += "'" + id + "',";
            sql += "'" + txtVehiNo.Text + "',";
            sql += "'" + txtModel.Text + "','Available')";

            vo.getDT(sql);
        }


        lblmsg.Text = "Data Saved";
    }

    void DataSearch()
    {
        DataTable dt = vo.getDT("select * from t_BIkeCar where VehiNo = '" + txtVehiNo.Text + "'");
        if (dt.Rows.Count == 0)
        {
            txtModel.Text = "";
            txtBrand1.Text = "";
            txtBrand2.Text = "";
            txtEngineType.Text = "";
            txtPerson.Text = "";
            txtAmount.Text = "";
            txtqty.Text = "";
        }
        else
        {
            txtModel.Text = dt.Rows[0].ItemArray[1].ToString();
            txtBrand1.Text = dt.Rows[0].ItemArray[2].ToString();
            txtBrand2.Text = dt.Rows[0].ItemArray[3].ToString();
            txtEngineType.Text = dt.Rows[0].ItemArray[4].ToString();
            txtPerson.Text = dt.Rows[0].ItemArray[5].ToString();
            txtAmount.Text = dt.Rows[0].ItemArray[6].ToString();
            txtqty.Text = dt.Rows[0].ItemArray[7].ToString();
        }
    }
}