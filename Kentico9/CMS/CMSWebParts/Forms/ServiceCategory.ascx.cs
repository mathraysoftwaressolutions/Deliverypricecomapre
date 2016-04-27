using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CMS.PortalControls;
using CMS.Helpers;

public partial class CMSWebParts_Forms_ServiceCategory : CMSAbstractWebPart
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
            mvCategories.SetActiveView(Vgrid); 
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
            DataSet ds = objBooking.getCategories();
            gvCategories.DataSource = ds;
            gvCategories.DataBind();
        }
        catch (Exception ex)
        {

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
    protected void gvCategories_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int grow = Convert.ToInt32(e.CommandArgument);

            int CategoryId = Convert.ToInt32(gvCategories.DataKeys[grow]["ItemID"].ToString());
            //int TaxDefinationId = Convert.ToInt32(gvChargeName.DataKeys[grow]["ApplyTaxId"].ToString());
            string MainChargeName = gvCategories.DataKeys[grow]["Main_Category"].ToString();
           // string SubChargeName = gvCategories.DataKeys[grow]["SubChargeName"].ToString();
            ViewState["CategoryId"] = CategoryId;
            if(e.CommandName=="Edit1")
            {
                txtCategoryname.Text = MainChargeName;
                btnSubmit.Text = "Save";
                mvCategories.SetActiveView(vAdd);
            }
            if(e.CommandName=="Delete1")
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
        int itemid = 0;
        if(btnSubmit.Text=="Save")
        {
            itemid = Convert.ToInt32(ViewState["CategoryId"].ToString());
        }
            int res=objBooking.insertupdateMainCategory(itemid,txtCategoryname.Text);
    }
    protected void lnkbtnAdd_Click(object sender, EventArgs e)
    {

    }
}



