using System.Collections.Generic;
using System.Data.Entity;

namespace Tasks
{
    public class TarefaDatabaseInitializer : DropCreateDatabaseIfModelChanges<TarefaContext>
    {
        protected override void Seed(TarefaContext context)
        {
            GetClientes().ForEach(c => context.Clientes.Add(c));
            GetSistemas().ForEach(sis => context.Sistemas.Add(sis));
            GetSituacoes().ForEach(sit => context.Situacoes.Add(sit));
            GetTarefas().ForEach(t => context.Tarefas.Add(t));
            GetTipoUsuarios().ForEach(tu => context.TipoUsuarios.Add(tu));
            GetUsuarios().ForEach(u => context.Usuario.Add(u));
            /*GetTarefaClientes().ForEach(tc => context.TarefaClientes.Add(tc));*/
        }

        private static List<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>
            {
                new Cliente {
                    IDCliente = "W001",
                    NomeCliente = "CFCW SOROCABA",
                    Sistema = 4
                },
                new Cliente {
                    IDCliente = "W002",
                    NomeCliente = "CFCW VOTORANTIM",
                    Sistema = 4
                },
                new Cliente {
                    IDCliente = "B001",
                    NomeCliente = "CFCB ITU",
                    Sistema = 3
                },
                new Cliente {
                    IDCliente = "B002",
                    NomeCliente = "CFCB SALTO",
                    Sistema = 3
                },
                new Cliente {
                    IDCliente = "A001",
                    NomeCliente = "CFCA SAO PAULO",
                    Sistema = 2
                },
                new Cliente {
                    IDCliente = "A002",
                    NomeCliente = "CFCA COTIA",
                    Sistema = 2
                },
                new Cliente {
                    IDCliente = "BR001",
                    NomeCliente = "BR ITAPETININGA",
                    Sistema = 1
                },
                new Cliente {
                    IDCliente = "BR002",
                    NomeCliente = "BR SAO MIGUEL",
                    Sistema = 1
                },
                new Cliente {
                    IDCliente = "FR001",
                    NomeCliente = "LJ REGISTRO",
                    Sistema = 5
                },
                new Cliente {
                    IDCliente = "FR002",
                    NomeCliente = "LJ JUQUIA",
                    Sistema = 5
                },
                new Cliente {
                    IDCliente = "D001",
                    NomeCliente = "D MIRACATU",
                    Sistema = 6
                },
                new Cliente {
                    IDCliente = "D002",
                    NomeCliente = "D BAHIA",
                    Sistema = 6
                },
                new Cliente {
                    IDCliente = "S001",
                    NomeCliente = "SGF CURITIBA",
                    Sistema = 7
                },
                new Cliente {
                    IDCliente = "S002",
                    NomeCliente = "SGF PARANA",
                    Sistema = 7
                },
                new Cliente {
                    IDCliente = "SW001",
                    NomeCliente = "SW CURITIBA",
                    Sistema = 8
                },
                new Cliente {
                    IDCliente = "SW002",
                    NomeCliente = "SW PARANA",
                    Sistema = 8
                }
            };
            return clientes;
        }

        private static List<Sistema> GetSistemas()
        {
            var sistemas = new List<Sistema>
            {
                new Sistema
                {
                    IDSistema = 1,
                    NomeSistema = "br doctor",
                    Gestor = 1,
                    Email = "brdoctor@email.com"
                },
                new Sistema
                {
                    IDSistema = 2,
                    NomeSistema = "cfca",
                    Gestor = 2,
                    Email = "cfca@email.com"
                },
                new Sistema
                {
                    IDSistema = 3,
                    NomeSistema = "cfcb",
                    Gestor = 3,
                    Email = "cfcb@email.com"
                },
                new Sistema
                {
                    IDSistema = 4,
                    NomeSistema = "cfcweb",
                    Gestor = 3,
                    Email = "cfcb@email.com"
                },
                new Sistema
                {
                    IDSistema = 5,
                    NomeSistema = "focus",
                    Gestor = 5,
                    Email = "focus@email.com"
                },
                new Sistema
                {
                    IDSistema = 6,
                    NomeSistema = "sdpwin",
                    Gestor = 6,
                    Email = "sdpwin@email.com"
                },
                new Sistema
                {
                    IDSistema = 7,
                    NomeSistema = "sgf",
                    Gestor = 7,
                    Email = "sgf@email.com"
                },
                new Sistema
                {
                    IDSistema = 8,
                    NomeSistema = "site",
                    Gestor = 8,
                    Email = "site@email.com"
                },
            };
            return sistemas;
        }

        private static List<Situacao> GetSituacoes()
        {
            var situacoes = new List<Situacao>
            {
                new Situacao
                {
                    IDSituacao = 1,
                    NomeSituacao = "pendente"
                },
                new Situacao
                {
                    IDSituacao = 2,
                    NomeSituacao = "iniciada"
                },
                new Situacao
                {
                    IDSituacao = 3,
                    NomeSituacao = "finalizada"
                },
                new Situacao
                {
                    IDSituacao = 4,
                    NomeSituacao = "cancelada"
                },
            };
            return situacoes;
        }

        private static List<TipoUsuario> GetTipoUsuarios()
        {
            var tipoUsuarios = new List<TipoUsuario> {
                new TipoUsuario {
                    IDTipoUsuario = 1,
                    TpUsuario = "padrao"
                },
                new TipoUsuario {
                    IDTipoUsuario = 2,
                    TpUsuario = "gestor"
                },
                new TipoUsuario {
                    IDTipoUsuario = 3,
                    TpUsuario = "desenvolvedor"
                }
            };
            return tipoUsuarios;
        }

        private static List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario> {
                new Usuario {
                    IDUsuario = 1,
                    NomeUsuario = "gestor br",
                    Tipo = 2,
                    Email = "gestorbr@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 2,
                    NomeUsuario = "gestor cfca",
                    Tipo = 2,
                    Email = "gestorcfca@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 3,
                    NomeUsuario = "gestor cfcb",
                    Tipo = 2,
                    Email = "gestorcfcb@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 4,
                    NomeUsuario = "padrao",
                    Tipo = 1,
                    Email = "padrao@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 5,
                    NomeUsuario = "gestor focus",
                    Tipo = 2,
                    Email = "gestorfocus@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 6,
                    NomeUsuario = "gestor sdpwin",
                    Tipo = 2,
                    Email = "gestorsdpwin@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 7,
                    NomeUsuario = "gestor sgf",
                    Tipo = 2,
                    Email = "gestorsgf@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 8,
                    NomeUsuario = "gestor site",
                    Tipo = 2,
                    Email = "gestorsite@email.com",
                    Senha = "123456"
                },
                new Usuario {
                    IDUsuario = 9,
                    NomeUsuario = "desenvolvedor",
                    Tipo = 3,
                    Email = "desenvolvedor@email.com",
                    Senha = "123456"
                }
            };
            return usuarios;
        }

        private static List<Tarefa> GetTarefas()
        {
            var tarefas = new List<Tarefa> {
                new Tarefa
                {
                    IDTarefa = 1,
                    Cadastrante = 1,
                    Sistema = 1,
                    Ordem = 0,
                    Titulo = "Tarefa 01 BrDoctor",
                    Descricao = "Tarefa 01 BrDoctor...",
                    Situacao = 1,
                    DataPrevisao = 15/07/2022,
                    DataCadastro = 15/07/2022,
                    Cliente = "BR001",
                    app= false
                },
                new Tarefa
                {
                    IDTarefa = 2,
                    Cadastrante = 2,
                    Sistema = 2,
                    Ordem = 1,
                    Titulo = "Tarefa 01 CFCA",
                    Descricao = "Tarefa 01 CFCA...",
                    Situacao = 2,
                    DataPrevisao = 10/04/2022,
                    DataCadastro = 29/02/2022,
                    Cliente = "A002",
                    app= false
                },
                new Tarefa
                {
                    IDTarefa = 4,
                    Cadastrante = 3,
                    Sistema = 3,
                    Ordem = 0,
                    Titulo = "Tarefa 01 CFCB",
                    Descricao = "Tarefa 01 CFCB...",
                    Situacao = 4,
                    DataInicio = 29/03/2022,
                    DataFim = 29/03/2022,
                    DataCadastro = 29/02/2022,
                    Cliente = "B001",
                    app= false
                },
                new Tarefa
                {
                    IDTarefa = 5,
                    Cadastrante = 3,
                    Sistema = 4,
                    Ordem = 1,
                    Titulo = "Tarefa 01 CFCWEB",
                    Descricao = "Tarefa 01 CFCWEB...",
                    Situacao = 2,
                    DataInicio = 29/03/2022,
                    DataCadastro = 29/02/2022,
                    Cliente = "W001",
                    app= false
                },
                new Tarefa
                {
                    IDTarefa = 6,
                    Cadastrante = 3,
                    Sistema = 4,
                    Ordem = 0,
                    Titulo = "Tarefa 02 CFCWEB",
                    Descricao = "Tarefa 02 CFCWEB...",
                    Situacao = 4,
                    DataInicio = 29/03/2022,
                    DataFim = 29/03/2022,
                    DataCadastro = 29/02/2022,
                    Cliente = "W001",
                    app= true
                },
            };
            return tarefas;
        }

        /*private static List<TarefaCliente> GetTarefaClientes()
        {
            var tarefaClientes = new List<TarefaCliente>
            {
                new TarefaCliente
                {
                    IDCliente = "BR001",
                    IDTarefa = 1,
                },
                new TarefaCliente
                {
                    IDCliente = "BR002",
                    IDTarefa = 1,
                },
                new TarefaCliente
                {
                    IDCliente = "A001",
                    IDTarefa = 2,
                },
                new TarefaCliente
                {
                    IDCliente = "A002",
                    IDTarefa = 2,
                },
                new TarefaCliente
                {
                    IDCliente = "B001",
                    IDTarefa = 3,
                },
                new TarefaCliente
                {
                    IDCliente = "B002",
                    IDTarefa = 3,
                },
                new TarefaCliente
                {
                    IDCliente = "W001",
                    IDTarefa = 4,
                },
                new TarefaCliente
                {
                    IDCliente = "W002",
                    IDTarefa = 4,
                },
                new TarefaCliente
                {
                    IDCliente = "W001",
                    IDTarefa = 5,
                },
                new TarefaCliente
                {
                    IDCliente = "W002",
                    IDTarefa = 5,
                },


            };
            return tarefaClientes;
        }*/
    }
}