using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
public partial class FileManager_Uploader : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AuthenticateFileManager();
    }



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

    protected void bntUpload_Click(object sender, EventArgs e)
    {
        string FilePath = Server.MapPath(txtPath.Text.Replace("//","/") + FileUpload1.FileName.ToString());
        FilePath = HttpUtility.UrlDecode(FilePath);
        if(System.IO.File.Exists(FilePath))
        {
            spanerror.InnerHtml = "<br/> "+FileUpload1.FileName.ToString() +" File Exists ";
        }
        else
        {
            FileUpload1.SaveAs(FilePath);
        }
        
         
    }
}