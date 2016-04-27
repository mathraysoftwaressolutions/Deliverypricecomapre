using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




using CMS.PortalControls;
using CMS.Helpers;

public partial class CMSWebParts_Forms_BookingFeeWebpart : CMSAbstractWebPart
{
    #region "Properties"
    Booking objbooking = new Booking();
    DataTable dtcomp = new DataTable();
    string ToValue = "";
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
            load();
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
    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{
    //    DataSet dsbooking = objbooking.getBookingFee();
    //    gvbookingfee.DataSource = dsbooking;
    //    gvbookingfee.DataBind();
    //}
    protected void load()
    {
        DataSet dsbooking = objbooking.getBookingFee();
        ViewState["ExistingBookingFee"] = dsbooking.Tables[0];
        gvbookingfee.DataSource = dsbooking;
        gvbookingfee.DataBind();
        vSlabs.Visible = true;
        vAddSlab.Visible = false;
    }
    protected void gvmeteredrate_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            DataTable dtcomp1 = new DataTable();
            //dtcomp1 = (DataTable)ViewState["Company"];
            //companydetails();
            if (dtcomp.Columns.Count < 1)
            {
                dtcomp.Columns.Add("SlabFrom");
                dtcomp.Columns.Add("SlabTo");
                dtcomp.Columns.Add("Booking_Fee");

            }
            dtcomp.Rows.Clear();
            int gvRow = Convert.ToInt32(e.CommandArgument);
            foreach (GridViewRow dgr in gvmeteredrate.Rows)
            {
                TextBox txtFrom = (TextBox)dgr.FindControl("txtFrom");
                TextBox txtTo = (TextBox)dgr.FindControl("txtTo");
                TextBox txtRate = (TextBox)dgr.FindControl("txtRate");

                DataRow drrow = dtcomp.NewRow();
                drrow["SlabFrom"] = txtFrom.Text;
                drrow["SlabTo"] = txtTo.Text;
                drrow["Booking_Fee"] = txtRate.Text;
                dtcomp.Rows.Add(drrow);
            }
            if (e.CommandName == "PageDelete")
            {
                dtcomp.Rows.RemoveAt(gvRow);
                ViewState["BookingFee"] = dtcomp;
                filmetergrid();
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
    private void filmetergrid()
    {
        DataTable dtcomp1 = new DataTable();
        dtcomp1 = (DataTable)ViewState["BookingFee"];
        if (ViewState["BookingFee"] != null)
        {
            gvmeteredrate.DataSource = dtcomp1;
            gvmeteredrate.DataBind();
        }
        else
        {
            DataRow drnewrow = dtcomp1.NewRow();
            drnewrow["SlabFrom"] = "";
            drnewrow["SlabTo"] = "";
            drnewrow["Booking_Fee"] = "";
            //drnewrow["Dated"] = "";
            dtcomp1.Rows.Add(drnewrow);
            ViewState["BookingFee"] = dtcomp1;
        }
    }

    protected void btnAddNewRow_Click(object sender, EventArgs e)
    {
        try
        {
            // Meteredetails();
            string value = "0.00";string Val = "0.01";
            DataTable dtcomp = new DataTable();
            dtcomp.Rows.Clear();
            //code to add next slab from value for the first time coming from the add slabs
            if(gvmeteredrate.Rows.Count<1)
            {
                DataTable dtexist = (DataTable)ViewState["ExistingBookingFee"];
                if (dtexist.Rows.Count > 0)
                {
                    value = (Convert.ToDecimal(dtexist.Rows[dtexist.Rows.Count-1]["SlabTo"].ToString()) + Convert.ToDecimal(Val)).ToString();
                }
            }
            foreach (GridViewRow dgr in gvmeteredrate.Rows)
            {
                TextBox txtFrom = (TextBox)dgr.FindControl("txtFrom");
                TextBox txtTo = (TextBox)dgr.FindControl("txtTo");
                TextBox txtRate = (TextBox)dgr.FindControl("txtRate");
                //TextBox txtDate = (TextBox)dgr.FindControl("txtDate");
                txtFrom.Enabled = false;
                if (dtcomp.Columns.Count < 1)
                {
                    dtcomp.Columns.Add("SlabFrom");
                    dtcomp.Columns.Add("SlabTo");
                    dtcomp.Columns.Add("Booking_Fee");

                    //dtcomp.Columns.Add("Dated");
                    //ViewState["Meter"] = dtcomp;
                }

                DataRow drrow = dtcomp.NewRow();


                drrow["SlabFrom"] = txtFrom.Text;
                drrow["SlabTo"] = txtTo.Text;
                drrow["Booking_Fee"] = txtRate.Text;
                //txtTo.Text = ToValue;
                //drrow["Dated"] = txtDate.Text;
                dtcomp.Rows.Add(drrow);
            }
            ViewState["BookingFee"] = dtcomp;
            if (dtcomp.Columns.Count < 1)
            {
                dtcomp.Columns.Add("SlabFrom");
                dtcomp.Columns.Add("SlabTo");
                dtcomp.Columns.Add("Booking_Fee");
                //dtcomp.Columns.Add("Dated");
                //ViewState["Meter"] = dtcomp;
            }


         
            if (ViewState["BookingFee"] != null)
            {
                DataTable dt = (DataTable)ViewState["BookingFee"];
                if (dt.Rows.Count > 0 && dt.Rows[dt.Rows.Count - 1]["SlabTo"].ToString() != "")
                {

                    ToValue = Convert.ToDecimal(dt.Rows[dt.Rows.Count - 1]["SlabTo"].ToString()).ToString();

                    double Num = Convert.ToDouble(ToValue);
                    string Total = Num.ToString("N2");

                    //string Val = "0.01";
                    value = (Convert.ToDecimal(Total) + Convert.ToDecimal(Val)).ToString();

                    double Num1 = Convert.ToDouble(value);
                    string Total1 = Num1.ToString("N2");

                    value = Total1;

                }

            }

            btnFinalizeslab.Visible = true;

            DataRow drnewrow = dtcomp.NewRow();

            drnewrow["SlabFrom"] = value;
            drnewrow["SlabTo"] = "";
            drnewrow["Booking_Fee"] = "";
            //drnewrow["Dated"] = "";
            dtcomp.Rows.Add(drnewrow);
            ViewState["BookingFee"] = dtcomp;
            filmetergrid();
            //divGrids.Visible = true;

            string message = "Slabs Finalized Successfully";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            //System.Web.UI.ClientScriptManager objclientscrpt = new ClientScriptManager();
            //System.Web.UI.ClientScriptManager.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());


        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
    protected void lnkbtnAddSlabs_Click(object sender, EventArgs e)
    {
        //Code for showing the slads part where slabs can be added
        vSlabs.Visible = false;
        vAddSlab.Visible = true;
       // gvmeteredrate.DataSource = null;
       //gvmeteredrate.DataBind();
       //ViewState["BookingFee"] = null;
        btnSubmit.Visible = false;
        btnFinalizeslab.Enabled = true;
        btnFinalizeslab.Visible = false;
        btnAddNewRow.Enabled = true;
       
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            //code to save slabs to the DB 
            DataTable dtslb = (DataTable)ViewState["BookingFee"];
            for (int vloop = 0; vloop < dtslb.Rows.Count; vloop++)
            {
                objbooking.insertupdateBookingFee(0, Convert.ToDecimal(dtslb.Rows[vloop]["Booking_Fee"].ToString()), Convert.ToDecimal(dtslb.Rows[vloop]["SlabFrom"].ToString()),
                    Convert.ToDecimal(dtslb.Rows[vloop]["SlabTo"].ToString()));
            }
            DataSet dsbooking = objbooking.getBookingFee();
            gvbookingfee.DataSource = dsbooking;
            gvbookingfee.DataBind();
            vSlabs.Visible = true;
            vAddSlab.Visible = false;
            gvmeteredrate.DataSource = null;
            gvmeteredrate.DataBind();
            ViewState["BookingFee"] = null;
        }

        catch (Exception ex)
        {
            //Response.Redirect("UnitMappingMeteredRate.aspx");
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
    protected void btnload_Click(object sender, EventArgs e)
    {
        load();
    }
    protected void txtRate_TextChanged(object sender, EventArgs e)
    {
        try
        {
            GridViewRow currentRow = (GridViewRow)((TextBox)sender).Parent.Parent;

            TextBox txtRate = (TextBox)currentRow.FindControl("txtRate");
            string finalval = "0.00";
            string[] stramtval = (txtRate.Text).Split('.');
            if (stramtval.Length > 1)
            {
                finalval = txtRate.Text;
            }
            else
            {
                finalval = txtRate.Text + ".00";
            }



            txtRate.Text = finalval;
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnFinalizeslab_Click(object sender, EventArgs e)
    {
        try
        {
            if (dtcomp.Columns.Count < 1)
            {
                dtcomp.Columns.Add("SlabFrom");
                dtcomp.Columns.Add("SlabTo");
                dtcomp.Columns.Add("Booking_Fee");

            }
            dtcomp.Rows.Clear();
            foreach (GridViewRow dgr in gvmeteredrate.Rows)
            {
                TextBox txtFrom = (TextBox)dgr.FindControl("txtFrom");
                TextBox txtTo = (TextBox)dgr.FindControl("txtTo");
                TextBox txtRate = (TextBox)dgr.FindControl("txtRate");

                DataRow drrow = dtcomp.NewRow();
                drrow["SlabFrom"] = txtFrom.Text;
                drrow["SlabTo"] = txtTo.Text;
                drrow["Booking_Fee"] = txtRate.Text;
                dtcomp.Rows.Add(drrow);
            }
            ViewState["BookingFee"] = dtcomp;

          
            btnAddNewRow.Enabled = false;
            btnFinalizeslab.Enabled = false;
            btnSubmit.Visible = true;
            string message = "Slabs Finalized Successfully";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
           // ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", ex.Message, true);
        }
    }
}



