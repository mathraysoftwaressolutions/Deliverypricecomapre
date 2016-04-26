using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Booking
/// </summary>
public class Booking
{
    public ArrayList AL = new ArrayList();
    public static string SqlConnection = ConfigurationManager.AppSettings["constr"].ToString();
	public Booking()
	{
		
	}
    public DataSet getBookingFee()
    {
        AL.Clear();
        return SqlHelper.ExecuteDataset(SqlConnection, CommandType.StoredProcedure, "sp_getBookingFee", (SqlParameter[])AL.ToArray(typeof(SqlParameter)));
    }
    //public int FunctionCheckUserEmail(string Email) //  District ddl fill method name   SP_UserNameExist
    //{
    //    AL.Clear();
    //    AL.Add(new SqlParameter("@Email", Email));
    //    return Convert.ToInt32(SqlHelper.ExecuteScalar(SqlConnection, CommandType.StoredProcedure, "sp_emailexist", (SqlParameter[])AL.ToArray(typeof(SqlParameter))));
    //}
    public int insertupdateBookingFee(int ItemID, decimal Booking_Fee, decimal SlabFrom, decimal SlabTo)
    {
        AL.Clear();
        AL.Add(new SqlParameter("@ItemID", ItemID));
        AL.Add(new SqlParameter("@Booking_Fee", Booking_Fee));
        AL.Add(new SqlParameter("@SlabFrom", SlabFrom));
        AL.Add(new SqlParameter("@SlabTo", SlabTo));
        return SqlHelper.ExecuteNonQuery(SqlConnection, CommandType.StoredProcedure, "sp_insupdBookingFee", (SqlParameter[])AL.ToArray(typeof(SqlParameter)));
    }
    #region Categories
    public int insertupdateMainCategory(int ItemID, string Main_Category)
    {
        AL.Clear();
        AL.Add(new SqlParameter("@ItemID", ItemID));
        AL.Add(new SqlParameter("@Main_Category", Main_Category));
        return SqlHelper.ExecuteNonQuery(SqlConnection, CommandType.StoredProcedure, "sp_insupdMainCategory", (SqlParameter[])AL.ToArray(typeof(SqlParameter)));
    }

    public DataSet getCategories()
    {
        AL.Clear();
        return SqlHelper.ExecuteDataset(SqlConnection, CommandType.StoredProcedure, "sp_getMainCategories", (SqlParameter[])AL.ToArray(typeof(SqlParameter)));
    }

    public int insertupdateSubCategory(int ItemID, int Main_CategoryId, string Sub_Category_Name)
    {
        AL.Clear();
        AL.Add(new SqlParameter("@ItemID", ItemID));
        AL.Add(new SqlParameter("@Main_CategoryId", Main_CategoryId));
        AL.Add(new SqlParameter("@Sub_Category_Name", Sub_Category_Name));
        return SqlHelper.ExecuteNonQuery(SqlConnection, CommandType.StoredProcedure, "sp_insupdBookingFee", (SqlParameter[])AL.ToArray(typeof(SqlParameter)));
    }

    public DataSet getsubcategories()
    {
        AL.Clear();
        return SqlHelper.ExecuteDataset(SqlConnection, CommandType.StoredProcedure, "sp_getSubCategories", (SqlParameter[])AL.ToArray(typeof(SqlParameter)));
    }
    #endregion
}