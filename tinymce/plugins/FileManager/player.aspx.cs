using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_ACMSTextBox_JavaScript_tiny_mce_plugins_FileManager_player : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AuthenticateFileManager();
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        if(Request["Path"] != null )
        {
            OpenFile(Request["Path"].ToString());
        }
        
    }




    private void OpenFile( string FilePath )
    {

       

        string EX = System.IO.Path.GetExtension(FilePath);
        string HTML = string.Empty;
        if ((EX == ".gif") || (EX == ".jpg") || (EX == ".png") || (EX == ".bmp") || (EX == ".icon") || (EX == ".GIF") || (EX == ".JPG") || (EX == ".PNG") || (EX == ".BMP") || (EX == ".ICON"))
        {
            HTML = GetImageHTML(FilePath.Replace("//", "/"));
        }
        else
        {
            HTML = "1";
        }

        Response.Clear();
        Response.Write(HTML);
        Response.End();
    }

    private string GetImageHTML(string FilePath)
    {
        string html = "<img  style='' src=" + FilePath.Replace(" ", "%20") + " />";
        return html;
    }


    // chnage this funcation if you want to create your Authenticate 
    public void AuthenticateFileManager()
    {
        /* Edit this funcation to  AuthenticateFileManager*/
        string SessionID = Request["sessionid"].ToString();

        if (Request.Cookies[SessionID] != null)
        {

        }
        else
        {
            Response.Clear();
            Response.Write("Access Denied");
            Response.End();
        }


    }

}