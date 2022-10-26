using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    VehiOperation vo = new VehiOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
            string sql = "Select * from t_IR where IssuedDate between '" + txtDate.Text + "' and '" + txtTo.Text + "'";
            grddate.DataSource = vo.getDT(sql);
            grddate.DataBind();

            Response.Write("Datails Found");
    }
       


    }


    
