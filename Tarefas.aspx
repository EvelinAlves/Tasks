<%@ Page Title="Tarefas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Tarefas.aspx.cs" Inherits="Tarefas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="filtro-flex-container">
        <div class="filtro-flex-item">
            <asp:DropDownList CssClass="btn dropdown-toggle" ID="ddlStatus" runat="server" Width="200px">
                <asp:ListItem Value="0">Todos</asp:ListItem>
                <asp:ListItem Value="1">Pendentes</asp:ListItem>
                <asp:ListItem Value="2">Inicializados</asp:ListItem>
                <asp:ListItem Value="3">Finalizados</asp:ListItem>
                <asp:ListItem Value="4">Cancelados</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="filtro-flex-item">
            <asp:DropDownList  CssClass="btn dropdown-toggle" ID="ddlClientes" runat="server" DataTextField="NomeCliente" DataValueField="IdCliente" Width="200px">
            </asp:DropDownList>
        </div>
        <div class="filtro-flex-item">
            <asp:Button CssClass="btn btn-success" ID="btnOK" runat="server" Width="50px" Text="OK" OnClick="btnOK_Click"/>
            <div class="btn-group" role="group" aria-label="...">
                <button type="button" Class="btn btn-success" onclick="AbrirPopupForm('novo')">
                    <span>+</span>
                </button>
            </div>
        </div>
    </div>

    <div class="grid-view">
        <asp:GridView CssClass="panel"  ID="grdDados" runat="server" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True">
            <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <div class="btn-group btn-group-sm" role="group" aria-label="...">
                                <a onclick="AbrirPopupForm('editar', <%# Eval("IdTarefa") %>)" class="btn btn-info btn-grid"><i class="bi bi-pencil"></i></a>
                                <a class="btn btn-danger btn-grid"><i class="bi bi-trash"></i></a>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Situacao" HeaderText="Status" SortExpression="Status" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DataCadastro" HeaderText="Data" SortExpression="Data" DataFormatString="{0:MM/dd/yyyy}" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Sistema" HeaderText="Sistema" SortExpression="Sistema" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Ordem" HeaderText="Ordem" SortExpression="Ordem" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DataPrevisao" HeaderText="Previsao" SortExpression="DtPrevisao" DataFormatString="{0:MM/dd/yyyy}" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Titulo" HeaderText="Título" SortExpression="Titulo" >
                        <ItemStyle HorizontalAlign="Left" Width="100px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Descricao" HeaderText="Descrição" SortExpression="Descricao" >
                        <ItemStyle HorizontalAlign="Left" Width="300px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Cadastrante" HeaderText="Operador" SortExpression="Operador" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Desenvolvedor" HeaderText="Executante" SortExpression="Executante" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DataInicio" HeaderText="Início" SortExpression="DtInicio" DataFormatString="{0:MM/dd/yyyy}" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>
                    <asp:BoundField DataField="DataFim" HeaderText="Fim" SortExpression="DataFim" DataFormatString="{0:MM/dd/yyyy}" >
                        <ItemStyle HorizontalAlign="Center" Width="30px" VerticalAlign="Top" />
                    </asp:BoundField>

                    
                    
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    

    <script>
        const urlParams = new URLSearchParams(window.location.search);
        

        function AbrirPopupForm(acao, params) {
            console.log(acao, params)
            

            if (acao == 'editar') {
                myParam = params;
            } else {
                myParam = urlParams.get('id');
            }

            let largura = 800;
            let altura = 550;
            // Definindo meio da tela
            let esquerda = (screen.width - largura) / 2;
            var topo = (screen.height - altura) / 2;
            //var topo = 0;
            // mostrar popup centralizada na tela
            let popup = window.open("Formulario.aspx?id="+myParam+"&formOrigem=Tarefas&acao="+acao, "_blank", "toolbar=0, scrollbars=0, resizable=0, width=" + largura + ", height=" + altura + ", top=" + topo + ", left=" + esquerda);
        };

    </script>
    <style>
        .filtro-flex-container {
            display: flex;
            width: 100%;
            justify-content: flex-start;
            align-items: center;
            flex-flow: row wrap;
        }

        .filtro-flex-item {
            margin-right: 20px;
            margin-bottom: 10px;
            min-width: 100px;
        }

        .btn-group {
            margin-left: 20PX;
        }

        .dropdown-toggle {
            text-align: initial;
            background-color: #428bca;
            color: white;
        }

        .panel {
            width: 100%;
        }

        .item-style {
            font-size: 15px;
        }

        .btn-grid {
            width: 40px;
        }
    </style>

</asp:Content>
