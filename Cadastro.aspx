<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form runat="server" class="form-flex-container">
        <asp:ScriptManager runat="server">
            <Scripts>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
            </Scripts>
        </asp:ScriptManager>

        <div style="display: none">
                  <!--
            <div class="form-flex-item">
                <input id="sistema" runat="server" style="width: 200px" disabled="disabled" type="text" class="form-control" placeholder="Sistema"/>
                <asp:DropDownList  CssClass="btn btn-default" ID="ddlClientes" runat="server" DataTextField="Nome" DataValueField="IdCliente" Width="200px">
                </asp:DropDownList>
                <input id="responsavel" style="width: 200px" type="text" class="form-control"  placeholder="Operador"/>
            </div>
            <div class="form-flex-item">
                <input id="titulo" style="width: 340px" type="text" class="form-control" placeholder="Título"/>
                <input id="ordem" style="width: 100px" type="text" class="form-control" placeholder="Ordem"/>
                <input id="prazo" style="width: 160px" type="text" class="form-control" placeholder="Prazo"/>
            </div>
            <div class="form-flex-item">
                <textarea id="descricao" style="width: 700px; height: 100px" class="form-control" placeholder="Descrição"></textarea>
            </div>
        -->    

        </div>

        <div>
            
            <div class="form-flex-item">
                <div class="item">
                    <label for="txtSistema">Sistema: </label>
                    <asp:TextBox CssClass="form-control" Width="200px" Enabled="false" ID="txtSistema" runat="server"></asp:TextBox>
                </div>
                <div class="item">
                    <label for="ddlClientesCad">Cliente: </label>
                    <asp:DropDownList  CssClass="btn btn-default form-control" ID="ddlClientesCad" runat="server" DataTextField="NomeCliente" DataValueField="IdCliente" Width="200px">
                    </asp:DropDownList>
                </div>
                <div class="item">
                    <label for="ddlUsuarios">Operador: </label>
                    <asp:DropDownList  CssClass="btn btn-default form-control" ID="ddlUsuarios" runat="server" DataTextField="NomeUsuario" DataValueField="IdUsuario" Width="200px">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-flex-item">
                <div class="item" style="width: 400px">
                    <label for="txtTitulo">Título: </label>
                    <asp:TextBox CssClass="form-control" Width="340px" ID="txtTitulo" runat="server"></asp:TextBox>
                </div>
                <div class="item" style="width: 200px">
                    <label for="ddlOrdem">Ordem: </label>
                    <asp:DropDownList  CssClass="btn btn-default form-control" ID="ddlOrdem" runat="server" Width="150px">
                        <asp:ListItem Value="0">Sem Ordem</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="item" style="width: 200px">
                    <label for="txtPrazo">Prazo: </label>
                    <asp:TextBox CssClass="form-control" Width="160px" ID="txtPrazo" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <div class="form-flex-item">
                <asp:TextBox CssClass="form-control" Width="700px" Height="100px" ID="txtDescricao" runat="server"></asp:TextBox>
            </div>
                
        </div>

        <div class="form-flex-item button">
            <asp:Button CssClass="btn btn-success" ID="btnSalvar" runat="server" Text="Salvar" Width="100px" OnClick="BtnSalvar_Click" />
            <!--
            <div class="btn-group" role="group" aria-label="...">
                <button type="button" runat="server" style="width: 100px;" class="btn btn-success">
                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                </button>
            </div>
                -->
        </div>
    </form>

    <style>
        .form-flex-container {
            display: flex;
            flex-flow: row wrap;
            width: 100%;
            align-items: center;
            padding: 0 20px;
        }

        .form-flex-item {
            display: flex;
            margin-top: 10px;
            display: flex;
            min-width: 500px;
            width: 100%;
        }

        input, .btn-default {
            margin-right: 50px;
        }

        .button {
            justify-content: flex-end;
            width: 700px;
        }

        .item {
            display: flex;
            flex-flow: row wrap;
            align-items: center;
        }

        .btn-disabled {
            display: none;
        }

    </style>
</body>
</html>
