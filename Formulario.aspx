<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Formulario.aspx.cs" Inherits="Formulario" %>

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
    <form id="formTarefas" runat="server">
        <div class="form-row">
            <div class="form-check form-check-inline col-md-12">
                <input runat="server" type="checkbox" class="form-check-input" id="app"/>
                <label class="form-check-label" for="app">Aplicativo</label>
            </div>
        </div>
        <div class="form-row ddl">
            <div class="form-group col-md-4">
                <label for="txtSistemas">Sistema: </label>
                <input runat="server" type="text" class="form-control form-control-sm" id="txtSistemas" readonly="true"/>
            </div>
            <div class="form-group col-md-4">
                <label for="ddlCliente">Cliente: </label>
                <select datavaluefield="NomeCliente" runat="server" class="form-control form-control-sm" id="ddlCliente">
                </select>
            </div>
            <div class="form-group col-md-4">
                <label for="ddlUsuario">Usuario: </label>
                <select runat="server" class="form-control form-control-sm" id="ddlUsuario">
                </select>
            </div>            
        </div>
        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="txtSistema">Sistema: </label>
                <input runat="server" class="form-control form-control-sm"  id="txtSistema" type="text" max="100" min="50" />
            </div>
            <div class="form-group col-md-4">
                <label for="ddlClientes">Cliente: </label>
                <asp:DropDownList DataTextField="NomeCliente" DataValueField="IdCliente" ID="ddlClientes" runat="server" CssClass="form-control form-control-sm"></asp:DropDownList>
            </div>
            <div class="form-group col-md-4">
                <label for="ddlUsuarios">Usuario: </label>
                <asp:DropDownList DataTextField="NomeUsuario" DataValueField="IdUsuario" ID="ddlUsuarios" runat="server" CssClass="form-control form-control-sm"></asp:DropDownList>
            </div>            
        </div>
        <div class="form-row">
            <div class="form-group col-md-10">
                <label for="txtTitulo">Título: </label>
                <input runat="server" maxlength="20" type="text" class="form-control form-control-sm" id="txtTitulo"/>
            </div>
        
            <div class="form-group  col-md-2">
                <label for="ddlOrdem">Ordem: </label>
                <select datavaluefield="ordem" runat="server" class="form-control form-control-sm" id="ddlOrdem">
                    <option>Sem Ordem</option>
                    <option>1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
                    <option>5</option>
                </select>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-12">
                <label for="txtDescricao">Descrição: </label>
                <textarea runat="server" maxlength="500" class="form-control" id="txtDescricao" rows="5"></textarea>
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-3">
                <label for="txtDataPrevisao">Previsão: </label>
                <input runat="server" type="text" class="form-control form-control-sm" id="txtDataPrevisao"/>
            </div>
            <div class="btn-salvar col-md-9">
                <button type="submit" class="btn btn-primary">Salvar</button>
            </div>
        </div>
    </form>



    <style>
        .ddl {
            display: none;
        }
        .form-row {
            padding: 5px 15px;
            align-items: center;
            width: 100%;
        }
        .btn-salvar {
            text-align: end;
        }
        .btn {
            width: 100px;
        }
        .form-check {
            justify-content: flex-end;
            background-color: rgba(255, 243, 205, 0.4);
            padding: 10px;
            border-radius: 10px;
        }

        .ddl-flex-container {
            display: flex;
            width: 100%;
            justify-content: flex-start;
            align-items: center;
            flex-flow: row wrap;
        }

        .ddl-flex-item {
            height: 30px;
            margin-right: 20px;
            margin-bottom: 10px;
            min-width: 100px;
        }
        .form-check-label {
            margin-right: 10px;
        }
    </style>
</body>
</html>
