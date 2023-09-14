<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DettaglioContatto.aspx.cs" Inherits="RubricaTelefonica.DettaglioContatto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="DettagliContatti" runat="server">

           Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> <br />
            Cognome: <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox> <br />
             Indirizzo: <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox> <br />
            Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> <br />
            Numero di Telefono: <asp:TextBox ID="txtNumeroTelefono" runat="server"></asp:TextBox> <br />
            
        </div>

        <asp:Button ID="Button1" runat="server" Text="Modifica" OnClick="Button1_Click" /><br />
        <asp:Button ID="Button2" runat="server" Text="Elimina" OnClick="Button2_Click" /><br />
    </form>
</body>
</html>
