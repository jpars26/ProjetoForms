using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private String mensagem;
        private int existe;

        public Estacionamento(String veiculo, String data, String lado, int hora)
        {
            this.veiculo = veiculo;
            this.data = data;
            this.lado = lado;
            this.hora = hora;
            Atualizar_Situacao();
        }
        public Estacionamento()
        {

        }

        public void Cadastro(Estacionamento estacionamento)
        {
          verificarExiste2();

            if (existe == 1)
            {
                MessageBox.Show(this.mensagem);

            }
            else
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
            


        }

      

      /*  public int verificarExiste(String veiculo, String data, String lado, int hora)//0 - nao existe || numero > 0 existe
        {
            int r = 0; //0 - nao existe
            sql.CommandText = @"SELECT * FROM Estacionamento WHERE Veiculo = @veiculo and hora = @hora and data = @data";
            sql.Parameters.AddWithValue("@hora", this.ConverteHora(this.hora));
            sql.Parameters.AddWithValue("@veiculo", this.veiculo);
            sql.Parameters.AddWithValue("@data", converterData(this.data));
            sql.Connection = con.Conectar();
            dr = sql.ExecuteReader();


            try
            {

                if (dr.HasRows)
                {
                    dr.Read();
                    r = Convert.ToInt32(dr["Veiculo"]);
                    this.mensagem = ("O " + this.veiculo + ", já esta cadastrado as " + this.ConverteHora(this.hora) + " horas. Por favor cadastrar outro horario.");

                    
                }
                con.Desconectar();
                dr.Close();
                
            }
            catch (SqlException e)
            {
                
                this.mensagem = ("Erro ao executar verificador e " + sql.ExecuteScalar() + "");
                con.Desconectar();
            }

            return r;
        }
        */

        public void verificarExiste2()
        {


            sql.CommandText = @"SELECT COUNT(1) FROM Estacionamento WHERE Veiculo = @veiculo2 and Hora = @hora2 and Data = @data2";
            sql.Parameters.AddWithValue("hora2", this.hora);
            sql.Parameters.AddWithValue("veiculo2", this.veiculo);
            sql.Parameters.AddWithValue("data2", converterData(this.data));
            sql.Connection = con.Conectar();

            string result = sql.ExecuteScalar().ToString();


            string[] dadosDoCadastro = result.Split(':');
            try
            {
               

                if (Int16.Parse(dadosDoCadastro[0]) >= 1)
                {
                    this.mensagem = ("O " + this.veiculo + ", já esta cadastrado as " + this.hora + " horas. Por favor cadastrar outro horario.");

                    this.existe = 1;
                    con.Desconectar();
                }
                else
                {
                    con.Desconectar();
                    this.existe = 2;
                }
            }
            catch (SqlException e)
            {
                con.Desconectar();
                this.mensagem = ("Erro ao executar verificador e " + sql.ExecuteScalar() + "");
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
        public string ReceberMenssagem() => this.mensagem;

    }
}
