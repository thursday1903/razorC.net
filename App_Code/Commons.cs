using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Commons
/// </summary>
public class Commons
{
    public Commons()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static float volumetricCalculate(float h_weight, float l_weight, float w_weight)
    {
        try
        {
            return (h_weight * l_weight * w_weight) / 5000;
        }
        catch
        {
            return new float();
        }
    }

    public static void releaseDBConnecttion(WebMatrix.Data.Database db)
    {
        try { db.Close(); }
        catch { }
    }

    /// <summary>
    /// Sinh Invoice number theo chuan neu co se update lai format
    /// </summary>
    /// <returns></returns>
    public static String generateInvoiceNumber()
    {
        Random ran = new Random(int.Parse(DateTime.Now.ToString("HHmmss")));
        int value = ran.Next(0, 100000);
        return value.ToString().PadRight(10, '0');
    }

    public static String convertIntoSystemFormat(DateTime input)
    {
        if (input != null)
            //String dateTime = input.ToShortDateString();
            return input.ToString("MM/dd/yyyy");
        else
            return String.Empty;
    }

    public static Boolean dateCompare(DateTime fromDate, DateTime toDate)
    {
        if (fromDate.CompareTo(toDate) > 0)
            return false;
        return true;

    }

    public static Boolean dateCompare(String fromDate_, String toDate_)
    {
        try
        {
            DateTime fromDate = Convert.ToDateTime(fromDate_);
            DateTime toDate = Convert.ToDateTime(toDate_);
            if (fromDate.CompareTo(toDate) > 0)
                return false;
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }




    public static Boolean isInteger(object value)
    {
        try
        {
            int.Parse(value.ToString());
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static Boolean isDecimal(object value)
    {
        try
        {
            decimal decValue = new decimal(float.Parse(value.ToString()));
            return false;
        }
        catch
        {
            return true;
        }

    }
}