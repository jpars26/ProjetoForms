using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPEstacionamento
{
    public class Estacionamento
    {
        private Conexao con = new Conexao();
        private SqlCommand sql = new SqlCommand();

        private string veiculo;
        private string data;
        public string lado;
        public string situacao;
        
        private string mensagem;

        public Estacionamento(String veiculo, String data, String lado, String situacao)
        {
            this.veiculo = veiculo;
            this.data = data;
            this.lado = lado;
            this.situacao = situacao;
        }

        public void Cadastro(Estacionamento estacionamento)
        {
            //comando sql
            sql.CommandText = "insert into carros(Veiculo, Data, Lado, Situacao) values (@veiculo, @data, @lado, @situacao)";

            //parametros
            sql.Parameters.AddWithValue("veiculo", this.veiculo);
            sql.Parameters.AddWithValue("data", this.converterData(this.data));
            sql.Parameters.AddWithValue("lado", this.lado);
            sql.Parameters.AddWithValue("situacao", this.situacao);

            try
            {
                //conecta com o banco
                sql.Connection = con.Conectar();

                //executa o comando
                sql.ExecuteNonQuery();

                //desconecta
                con.Desconectar();
                this.mensagem = "O " + this.veiculo + " Cadastrado com sucesso!";
                this.situacao = "";
            }
            catch(SqlException e)
            {
                this.mensagem = "Erro ao tentar conectar com o banco de dados!!";
            }
        }

        public String converterData(String data)
        {
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo convertedata = cultura.DateTimeFormat;
            DateTime date = Convert.ToDateTime(data);
            String novadata = date.ToString("dddd") + ", dia " + date.ToString("dd") + " de " + date.ToString("MMMM");
            return novadata;
        }
    }
}
