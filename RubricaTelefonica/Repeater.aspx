<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="RubricaTelefonica.Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container d-flex flex-column">
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server" ItemType="RubricaTelefonica.Contatti">
                    <ItemTemplate>
                        <div class="col-4 mt-5">
                            <div >
                                <img style="width:150px" src="Content/img/<%# Item.Foto %>"/>
                            </div>
                            <p><strong><%# Item.Nome%></strong> <strong><%# Item.Cognome %></strong></p>
                            
                            <h2><%#Item.Indirizzo %></h2>
                            <a class="btn btn-success" href="DettaglioContatto.aspx?idContatto=<%# Item.IdContatto%>">Dettagli</a>
                            <hr />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

            

        </div>
    </form>
</body>
</html>