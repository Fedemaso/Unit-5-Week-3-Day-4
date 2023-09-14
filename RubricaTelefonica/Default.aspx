<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RubricaTelefonica.Default" %>

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
        <div>

             <div class="text-center d-flex flex-column align-items-center">
            Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> <br />
            Cognome: <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox> <br />
              Indirizzo: <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox> <br />
                  Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> <br />
                    Numero di Telefono: <asp:TextBox ID="txtNumeroTelefono" runat="server"></asp:TextBox> <br />

            <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />

            <asp:Button ID="Button1" class="my-3" runat="server" Text="Carica Contatto" OnClick="Button1_Click" />
                 <asp:Button ID="Button2" class="my-3"  runat="server" Text="Lista Contatti" OnClick="Button2_Click"/>
        </div>
    </form>
</body>
</html>
