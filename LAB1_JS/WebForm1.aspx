<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LAB1_JS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">

.container {
  width: 80%;
  height: 200px;
  margin: auto;
  padding: 10px;
}

.one {
  width: 30%;
  height: 1000px;
  
  float: left;
}

.two {
  margin-left: 15%;
  position: relative;
  height: 500px;


}

</style>
</head>
<body style="height: 1000px">
   
    
    <div class="container">
            <div class="one">
                 <form id="form1" runat="server">
            Okreśłenie rozmiaru elementów
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Value="s">Mały rozmiar elementu</asp:ListItem>
                <asp:ListItem Value="m">Średni rozmiar elementu</asp:ListItem>
                <asp:ListItem Value="x">Duży rozmiar elementu</asp:ListItem>
            </asp:RadioButtonList>
   
            Okreslenie polozenia rysunków
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="0">Kostka piątka</asp:ListItem>
                <asp:ListItem Value="1">Przekątna lewa</asp:ListItem>
                <asp:ListItem Value="2">Przekątna prawa</asp:ListItem>
                <asp:ListItem Value="3">Linia poziomo</asp:ListItem>
                <asp:ListItem Value="4">Linia pionowo</asp:ListItem>
            </asp:DropDownList>
             </form>
            </div>
            <div class ="two">
                <asp:Image ID="Image0" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image1" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image2" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image3" runat="server" src="/and.jpeg" width="50" height="50"></asp:Image>
                <asp:Image ID="Image4" runat="server" src="/and.jpeg" Width="50" Height="50"></asp:Image>
            </div>   
    </div>
    
   
     
    </body>
</html>
