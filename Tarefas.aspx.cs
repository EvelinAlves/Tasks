using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tasks;
using System.Data;

public partial class Tarefas : Page
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
            cmd.CommandText = "Select * from Clientes where Sistema = @idSistema";
            cmd.Parameters.AddWithValue("@idSistema", idSistema);
            con.Open();

            SqlDataReader sqlread = cmd.ExecuteReader();

            ddlClientes.DataSource = sqlread;
            ddlClientes.DataBind();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        String status = ddlStatus.SelectedValue.ToString();
        String cliente = ddlClientes.SelectedValue.ToString();

        System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
        System.Configuration.ConnectionStringSettings connString;
        connString = rootWebConfig.ConnectionStrings.ConnectionStrings["Tasks"];


        SqlConnection con = new SqlConnection();
        con.ConnectionString = connString.ToString();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

        if (status == "0")
        {
            cmd.CommandText = "Select * from Tarefas where Cliente= @Cliente";
            cmd.Parameters.AddWithValue("@Cliente", cliente);
        }
        else
        {
            cmd.CommandText = "Select * from Tarefas where Situacao= @Status and Cliente= @Cliente";
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Cliente", cliente);
        }
        con.Open();


        SqlDataReader sqlread = cmd.ExecuteReader();

        DataTable tabela = new DataTable();
        tabela.Load(sqlread);

        grdDados.DataSource = tabela;
        grdDados.DataBind();

        con.Close();
        /*
         * DataSource: adiciona o valor no campo;
         * DataBind: mostra a informação no html;
        */
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        var idTarefa = 1;


        System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
        System.Configuration.ConnectionStringSettings connString;
        connString = rootWebConfig.ConnectionStrings.ConnectionStrings["Tasks"];

        SqlConnection con = new SqlConnection();
        con.ConnectionString = connString.ToString();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "DELETE from Alteracoes where IdAlteracao= @idTarefa;";
        cmd.Parameters.AddWithValue("@idTarefa", idTarefa);

        con.Open();

        cmd.ExecuteReader();
        con.Close();
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        var idTarefa = 11;
        string titulo = "titulo alterado";
        string descricao = "descricao alterada";
        var previsaoEntrega = "11/11/1111";
        var ordem = "100";
        var cliente = "S0001";

        System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
        System.Configuration.ConnectionStringSettings connString;
        connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];

        SqlConnection con = new SqlConnection();
        con.ConnectionString = connString.ToString();

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "UPDATE Alteracoes SET Titulo= @titulo, Descricao= @descricao, DtPrevisao= @previsaoEntrega, Ordem= @ordem, Cliente= @cliente WHERE IdAlteracao = @IdTarefa;";
        cmd.Parameters.AddWithValue("@idTarefa", idTarefa);
        cmd.Parameters.AddWithValue("@titulo", titulo);
        cmd.Parameters.AddWithValue("@descricao", descricao);
        cmd.Parameters.AddWithValue("@previsaoEntrega", previsaoEntrega);
        cmd.Parameters.AddWithValue("@ordem", ordem);
        cmd.Parameters.AddWithValue("@cliente", cliente);
        con.Open();
        cmd.ExecuteReader();
        con.Close();

    }

}