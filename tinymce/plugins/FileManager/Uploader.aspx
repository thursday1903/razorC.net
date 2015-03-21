<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uploader.aspx.cs" Inherits="FileManager_Uploader" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/ui-lightness/jquery-ui-1.8.4.custom.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .hide
        {
            display:none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="ui-widget-content" style="height:73px;border-right:0px;" >
    <asp:FileUpload ID="FileUpload1" runat="server"  /> 
    <asp:Button ID="bntUpload" runat="server" Text="upload" 
        onclick="bntUpload_Click" />   
    <span runat="server" style="font-weight:bold;color:Red" id="spanerror"></span>
    <asp:TextBox CssClass="hide" ID="txtPath" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
