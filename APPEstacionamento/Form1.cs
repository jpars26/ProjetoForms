using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPEstacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Desativar_Campo();
            Carrega_Tabela();
            campos_lipos();
            
        }
        public void campos_lipos()
        {
            TxtVeiculo.Text = "";
            TxtLado.Text = "";
            TxtIdCarro.Text = "";
            TxtHora.Text = "";
        }

        public bool CampoVazio(Control controle, String campo)
        {
            if (controle.Text == "")
            {
                MessageBox.Show("O campo " + campo + " é obrigatortio");
                controle.Focus();
                return true;

            }
            else
            {
                return false;
            }

        }
        private void estacionamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         

           
                if (CampoVazio(TxtVeiculo, "Veiculo"))
                {
                    return;
                }
                else if (CampoVazio(TxtLado, "Lado"))
                {
                    return;
                }
                else if (CampoVazio(TxtHora, "Hora"))
                {
                    return;
                }
                else
                {
                    this.Validate();
                    this.estacionamentoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bD_ProjetoDataSet);

                    String veiculo = $@"Veiculo {TxtVeiculo.Text}";
                    String lado = TxtLado.Text;
                    String data = TxtData.Text;
                    int hora = Convert.ToInt32(TxtHora.Text);

                    //sempre tem que chamar caso for criar um novo
                    Estacionamento estacionamento = new Estacionamento(veiculo, data, lado, hora);
                    //chamando a função cadastro
                    estacionamento.Cadastro(estacionamento);

                    MessageBox.Show(estacionamento.ReceberMenssagem());

                    data = TxtData.Value.ToShortDateString();

                    if (TxtData.Value > DateTime.Now)
                        MessageBox.Show("Data maior que a atual, impossivel continuar!!");

                }


            


            Carrega_Tabela();
            Desativar_Campo();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_ProjetoDataSet.Estacionamento' table. You can move, or remove it, as needed.
            this.estacionamentoTableAdapter.Fill(this.bD_ProjetoDataSet.Estacionamento);

        }

        public void Carrega_Tabela()
        {
            Conexao con = new Conexao();
            SqlCommand sql = new SqlCommand();

            sql.CommandText = "select * from estacionamento order by Data desc";

            sql.Connection = con.Conectar();

            //procurar sobre SqlDataAdapter 
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sql;

            //pesquisar -- DataSet
            DataSet dados = new DataSet();
            adapter.Fill(dados);
            DataGridBanco.DataSource = dados;
            DataGridBanco.DataMember = dados.Tables[0].TableName;

            con.Desconectar();






        }

        public bool Campo_Lado()
        {
            if (TxtLado.Text == "Direito")
                return true;
            else if (TxtLado.Text == "Esquerdo")
                return true;
            else
            {
                MessageBox.Show("Lado incorreto");
                return false;
            }


           
                

            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand sql = new SqlCommand();
                sql.Connection = con.Conectar();

                sql.CommandText = "delete from estacionamento where IdCarro = @idCarro";

                sql.Parameters.Clear();

                sql.Parameters.Add("@IdCarro", SqlDbType.Int).Value = TxtIdCarro.Text;

                sql.CommandType = CommandType.Text;
                sql.ExecuteNonQuery();
                MessageBox.Show("Excluido com sucesso!");
                con.Desconectar();
                Carrega_Tabela();
            }
            catch(Exception erro)
            {
                MessageBox.Show($@"Não foi possivel deletar: {erro}");
            }

        }

        public void Desativar_Campo()
        {
            TxtData.Enabled = false;
            TxtHora.Enabled = false;
            TxtLado.Enabled = false;
            TxtVeiculo.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnAdicionar.Enabled = true;

            
        }

        public void Ativar_Campos()
        {
            TxtData.Enabled = true;
            TxtHora.Enabled = true;
            TxtLado.Enabled = true;
            TxtVeiculo.Enabled = true;
            BtnSalvar.Enabled = true;
            BtnAdicionar.Enabled = false;

            TxtVeiculo.Text = "";
            TxtLado.Text = "";
            TxtIdCarro.Text = "";
            TxtHora.Text = "";

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja cadastrar o carro?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                Ativar_Campos();
                
            }
            else
            {
               
                Desativar_Campo();
            }
            
        }
    }
}
