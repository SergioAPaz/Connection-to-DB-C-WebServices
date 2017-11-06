<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proyecto1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div id="pnlTodasLasPeliculas">
                <p>Consultar todas las peliculas en GridView</p>
                <asp:GridView ID="GVPeliculas" CssClass="" runat="server" AutoGenerateColumns="false">
                    <HeaderStyle CssClass="" ForeColor="#fafafa" BackColor="#222" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" HeaderStyle-Width="50px" />
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" HeaderStyle-Width="150px" />
                        <asp:BoundField ItemStyle-ForeColor="#FF8800" HeaderText="Pelicula" DataField="Pelicula" HeaderStyle-Width="200px" />
                    </Columns>
                </asp:GridView>
            </div>

            <div id="ConsultaPorPelicula">
                <p>Consultar por atributo</p>
                <asp:TextBox runat="server" ID="txtCode"></asp:TextBox>
                <asp:Button runat="server" ID="btnSearch" OnClick="btnSearch_Click" Text="Buscar" />
                <asp:TextBox runat="server" ID="txtMovieName"></asp:TextBox>
            </div>

            <div id="IngrsarPelicula">
                <p>Agregar peliculas</p>
                <asp:TextBox runat="server" ID="txtCodigo"></asp:TextBox>
                <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
                <asp:Button runat="server" ID="btnSave" OnClick="btnSave_Click" Text="Agregar" />

            </div>
    </form>
</body>
</html>
