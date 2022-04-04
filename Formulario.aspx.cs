using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Formulario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            String paramsID = Request.QueryString["id"];
            String paramsAcao = Request.QueryString["acao"];

            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["Tasks"];

            if (paramsAcao == "editar")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connString.ToString();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Select * from Tarefas where idTarefa = @paramsID";
                cmd.Parameters.AddWithValue("@paramsID", paramsID);
                con.Open();

                SqlDataReader sqlread = cmd.ExecuteReader();
                if (sqlread.Read())
                {
                    app.Checked = (sqlread.GetValue(sqlread.GetOrdinal("app"))).ToString()=="1";
                    txtTitulo.Value = sqlread.GetValue(sqlread.GetOrdinal("Titulo")).ToString();
                    ddlOrdem.Value = sqlread.GetValue(sqlread.GetOrdinal("Ordem")).ToString();
                    txtDescricao.Value = sqlread.GetValue(sqlread.GetOrdinal("Descricao")).ToString();
                    txtDataPrevisao.Value = sqlread.GetValue(sqlread.GetOrdinal("DataPrevisao")).ToString();




                }
                con.Close();

            }

            if (paramsAcao == "novo")
            {

            }

            //Pegar o ID do sistema e buscar o nome do sistema


            //Buscar todos os clientes que tem esse sistema


            //Buscar todos os uruários


            /*
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

            con.Close();*/
        }
    }
}