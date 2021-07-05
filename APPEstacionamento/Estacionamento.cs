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

        private String veiculo;
        private String data;
        private String lado;
        private String situacao;
        private int hora;


        private string mensagem;

        public Estacionamento(String veiculo, String data, String lado, int hora)
        {
            this.veiculo = veiculo;
            this.data = data;
            this.lado = lado;
            this.hora = hora;
            Atualizar_Situacao();
        }

        public void Cadastro(Estacionamento estacionamento)
        {
            //comando sql
            sql.CommandText = "insert into Estacionamento (Veiculo, Data, Lado, Situacao, Hora) values (@veiculo, @data, @lado, @situacao, @hora)";

            //parametros
            sql.Parameters.AddWithValue("veiculo", this.veiculo);
            sql.Parameters.AddWithValue("data", this.converterData(this.data));
            sql.Parameters.AddWithValue("lado", this.lado);
            sql.Parameters.AddWithValue("situacao", this.situacao);
            sql.Parameters.AddWithValue("hora", this.hora);

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
            catch (SqlException e)
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

        public void Atualizar_Situacao()
        {

            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo convertedata = cultura.DateTimeFormat;
            DateTime oDate = Convert.ToDateTime(this.data);
            String dia = convertedata.GetDayName(oDate.Date.DayOfWeek);

            if (this.hora >= 7 && this.hora <= 20)
            {

                if (dia.Contains("domingo"))
                {

                    this.situacao = "Regular";

                }
                else if (dia.Contains("segunda-feira"))
                {

                    if (this.lado == "Direito")

                        this.situacao = "Regular";
                    else
                        this.situacao = "Irregular";

                }
                else if (dia.Contains("terça-feira"))
                {

                    if (this.lado == "Direito")
                    {

                        this.situacao = "Irregular";
                    }
                    else
                        this.situacao = "Regular";


                }
                else if (dia.Contains("quarta-feira"))
                {

                    if (this.lado == "Direito")
                    {
                        this.situacao = "Regular";
                    }
                    else
                        this.situacao = "Irregular";

                }
                else if (dia.Contains("quinta-feira"))
                {

                    if (this.lado == "Direito")
                        this.situacao = "Irregular";
                    else
                        this.situacao = "Regular";



                }
                else if (dia.Contains("sexta-feira"))
                {

                    if (this.lado == "Direito")
                        this.situacao = "Regular";
                    else
                        this.situacao = "Irregular";


                }
                else if (dia.Contains("sábado"))
                {

                    this.situacao = "Regular";

                }

            }
            else
                this.situacao = "Regular";
        


    }

    }
}
