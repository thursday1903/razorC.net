using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserLogin
/// </summary>
public class UserLogin
{
	public UserLogin()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    int userId;

    public int UserId
    {
        get { return userId; }
        set { userId = value; }
    }
    String username;

    public String Username
    {
        get { return username; }
        set { username = value; }
    }
    int accounttype;

    public int Accounttype
    {
        get { return accounttype; }
        set { accounttype = value; }
    }
    int accountId;

    public int AccountId
    {
        get { return accountId; }
        set { accountId = value; }
    }
    String active;

    public String Active
    {
        get { return active; }
        set { active = value; }
    }
    int fromCountry;

    public int FromCountry
    {
        get { return fromCountry; }
        set { fromCountry = value; }
    }

}