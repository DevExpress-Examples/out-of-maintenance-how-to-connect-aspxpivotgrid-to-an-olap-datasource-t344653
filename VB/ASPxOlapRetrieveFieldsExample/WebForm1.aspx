<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="ASPxOlapRetrieveFieldsExample.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientIDMode="AutoID" 
            EnableTheming="True"  
            Theme="Metropolis">
        </dx:ASPxPivotGrid>
        <br />
        <dx:ASPxPivotCustomizationControl ID="ASPxPivotCustomizationControl1" 
            runat="server" ASPxPivotGridID="ASPxPivotGrid1" Height="388px" Width="250px">
        </dx:ASPxPivotCustomizationControl>
    </div>
    </form>
</body>
</html>