using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using para o DB
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    class AcessaDadosSQLServer
    {
        //Criar a coneção com BD

        public SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConection);

        }

        //Parametros para o BD

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametro(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        private SqlCommand PreencheSqlCommand(CommandType commandType, string minhaUsp)
        {
            try
            {
                //Criar e abrir a conexão com o BD
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                //Criar e enviar os comandos ao BD
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;

                sqlCommand.CommandText = minhaUsp;

                //TiomeOut
                sqlCommand.CommandTimeout = 3600; //medido em segundos

                //Adicionar os parametros da Stored Procedure
                foreach (SqlParameter item in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }

                //Retorno da SqlCommand
                return sqlCommand;

            } catch (Exception ex)
            {
                //Dispara um novo evento de exeçao para ser manipulado na camada superior 
                //O formato de saida é diferente do exigido
                throw new Exception(ex.Message);
            }
        }

        //Inserir, Alterar e Excluir
        public object ManipulaDados(CommandType commandType, string minhaUsp)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                //Chamar a funcao que preenche a SqlCommand
                sqlCommand = PreencheSqlCommand(commandType, minhaUsp);

                //Executar a rotina em BD
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        //Consultas
        public DataTable ExecutaConsulta(CommandType commandType, string minhaUsp)
        {
            try
            {
                //Chamar a funcao que preenche a SqlCommand
                SqlCommand sqlCommand = PreencheSqlCommand(commandType, minhaUsp);

                //Criar um tradutor para o retorno do BD
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //Criar a DataTable
                DataTable dataTable = new DataTable();

                //Preencher o dataTable com os dados do BD
                sqlDataAdapter.Fill(dataTable);

                //retornar a consulta
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
