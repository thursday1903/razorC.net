using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FSCEnum
/// </summary>
public class FSCEnum
{
    public enum FSCEnum_
    { 
        DOX = 1,
        WPX = 0
    }

    public enum HandlingFeeType
    {
        Fixed = 0,
        Transhipments = 1
    }

    public enum AdminType
    {
        Account = 0,
        SubAccount = 1
    }
}