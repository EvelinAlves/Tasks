using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cadastro : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            String idSistema = Request.QueryString["id"];

            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["Tasks"];


            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Clientes where Sistema = @idSis";
            cmd.Parameters.AddWithValue("@idSis", idSistema);
            con.Open();

            SqlDataReader sqlread = cmd.ExecuteReader();

            ddlClientesCad.DataSource = sqlread;
            ddlClientesCad.DataBind();
            
            con.Close();


            SqlCommand cmdUsuario = new SqlCommand();
            cmdUsuario.Connection = con;
            cmdUsuario.CommandText = "Select * from Usuarios";
            con.Open();

            SqlDataReader sqlreadUsuario = cmdUsuario.ExecuteReader();

            ddlUsuarios.DataSource = sqlreadUsuario;
            ddlUsuarios.DataBind();

            con.Close();

            switch (idSistema)
            {
                case "5":
                    txtSistema.Text = "CFCWeb";
                    break;
                case "8":
                    txtSistema.Text = "CFC-A";
                    break;
                case "9":
                    txtSistema.Text = "CFC-B";
                    break;
                case "10":
                    txtSistema.Text = "Br Doctor";
                    break;
                case "11":
                    txtSistema.Text = "Focus";
                    break;
                case "13":
                    txtSistema.Text = "SDPWin";
                    break;
                case "14":
                    txtSistema.Text = "SGF";
                    break;
                case "15":
                    txtSistema.Text = "Site";
                    break;
            }
        }
    }

    protected void BtnSalvar_Click(object sender, EventArgs e)
    {
        String acao = Request.QueryString["acao"];
        String sistema = Request.QueryString["id"];

        System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
        System.Configuration.ConnectionStringSettings connString;
        connString = rootWebConfig.ConnectionStrings.ConnectionStrings["Tasks"];
        SqlConnection con = new SqlConnection();
        con.ConnectionString = connString.ToString();

        String titulo = txtTitulo.Text;
        String descricao = txtDescricao.Text;
        String previsaoEntrega = txtPrazo.Text;
        String ordem = ddlOrdem.SelectedValue;
        String cliente = ddlClientesCad.SelectedValue;

        if (acao == "novo")
        {
            String cadastrante = ddlUsuarios.SelectedValue;
            DateTime DataCadastro = DateTime.Today;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Tarefas (Situacao, Sistema, DataCadastro, Titulo, Descricao, DataPrevisao, Ordem, Cadastrante, Cliente, App) VALUES (1, @sistema, @DataCadastro, @titulo, @descricao, @previsaoEntrega, @ordem, @cadastrante, @cliente, 0);";
            cmd.Parameters.AddWithValue("@sistema", sistema);
            cmd.Parameters.AddWithValue("@DataCadastro", DataCadastro);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@previsaoEntrega", previsaoEntrega);
            cmd.Parameters.AddWithValue("@ordem", ordem);
            cmd.Parameters.AddWithValue("@cadastrante", cadastrante);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            con.Open();
            SqlDataReader sqlread = cmd.ExecuteReader();
            con.Close();

        }
        else if (acao == "edit")
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Tarefas SET Titulo= @titulo, Descricao= @descricao, DataPrevisao= @previsaoEntrega, Ordem= @ordem, Cliente= @cliente);";
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@previsaoEntrega", previsaoEntrega);
            cmd.Parameters.AddWithValue("@ordem", ordem);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            con.Open();
            SqlDataReader sqlread = cmd.ExecuteReader();
            con.Close();
        }

        btnSalvar.Enabled = false;
    }
}