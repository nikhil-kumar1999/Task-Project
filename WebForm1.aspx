<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task_Project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3 style="text-align: center; background-color: #C0C0C0; color: #0000FF; font-weight: bold; height: 33px;">Testing process</h3>
        </div>
        <div style="text-align: center">
          <b>Country :</b>  <asp:DropDownList ID="DropDownList1" runat="server" Width="243px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>State :</b>&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" Width="233px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; City :</b>&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" Width="233px">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
