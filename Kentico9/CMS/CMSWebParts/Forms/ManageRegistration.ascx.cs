using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CMSWebParts_Forms_ManageRegistration : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvMangeRegisterUsers_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRow row = ((DataRowView)e.Row.DataItem).Row;
            bool isActive = row.Field<int>("Fld_status") == 1;
            Label lbl_status = (Label)e.Row.FindControl("lbl_status");
            lbl_status.Text = isActive ? "active" : "inactive";
        }
    }
}