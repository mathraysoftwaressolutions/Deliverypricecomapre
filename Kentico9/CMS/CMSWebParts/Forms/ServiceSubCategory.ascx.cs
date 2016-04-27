using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CMS.PortalControls;
using CMS.Helpers;

public partial class CMSWebParts_Forms_ServiceSubCategory : CMSAbstractWebPart
{
    Booking objBooking = new Booking();
    #region "Properties"

    

    #endregion


    #region "Methods"

    /// <summary>
    /// Content loaded event handler.
    /// </summary>
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();
        SetupControl();
    }


    /// <summary>
    /// Initializes the control properties.
    /// </summary>
    protected void SetupControl()
    {
        if (this.StopProcessing)
        {
            // Do not process
        }
        else
        {
            fillgrid();
            mvSubCategories.SetActiveView(Vgrid);
        }
    }


    /// <summary>
    /// Reloads the control data.
    /// </summary>
    public override void ReloadData()
    {
        base.ReloadData();

        SetupControl();
    }

    #endregion
    protected void fillgrid()
    {
        try
        {
            DataSet ds = objBooking.getsubcategories();
            gvSubCategories.DataSource = ds;
            gvSubCategories.DataBind();
        }
        catch (Exception ex)
        {

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
    protected void gvSubCategories_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int grow = Convert.ToInt32(e.CommandArgument);

            int CategoryId = Convert.ToInt32(gvSubCategories.DataKeys[grow]["ItemID"].ToString());
            //int TaxDefinationId = Convert.ToInt32(gvChargeName.DataKeys[grow]["ApplyTaxId"].ToString());
            string MainChargeName = gvSubCategories.DataKeys[grow]["Main_Category"].ToString();
            // string SubChargeName = gvCategories.DataKeys[grow]["SubChargeName"].ToString();
            ViewState["CategoryId"] = CategoryId;
            if (e.CommandName == "Edit1")
            {
                txtCategoryname.Text = MainChargeName;
                btnSubmit.Text = "Save";
                mvSubCategories.SetActiveView(vAdd);
            }
            if (e.CommandName == "Delete1")
            {

            }
        }
        catch (Exception ex)
        {

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
    protected void lnkbtnAdd_Click(object sender, EventArgs e)
    {

    }
}



