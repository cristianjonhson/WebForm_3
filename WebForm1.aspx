<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="clase_29_09_2015.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Marca:"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="LinqDataSource1" DataTextField="Page" 
            DataValueField="HeaderContainer" Height="51px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="426px">
        </asp:DropDownList>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="AjaxControlToolkit.Accordion" EntityTypeName="" 
            TableName="Panes">
        </asp:LinqDataSource>
        <asp:DropDownExtender ID="DropDownList1_DropDownExtender" runat="server" 
            DynamicServicePath="" Enabled="True" TargetControlID="DropDownList1">
        </asp:DropDownExtender>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Articulos"></asp:Label>
        <asp:DropDownExtender ID="Label2_DropDownExtender" runat="server" 
            DynamicServicePath="" Enabled="True" TargetControlID="Label2">
        </asp:DropDownExtender>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
