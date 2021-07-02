using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            Carrega_Tabela();
        }

      

        private void estacionamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.estacionamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_ProjetoDataSet);

            String veiculo = $@"Veiculo {TxtVeiculo.Text}";
            String lado = TxtLado.Text;
            String data = "";

            data = TxtData.Value.ToShortDateString();

            if (TxtData.Value > DateTime.Now)
            {
                MessageBox.Show("Data maior que a atual, impossivel continuar!!");
            }
            else
            {
                if (Campo_Lado())
                {

                }
            }

            Carrega_Tabela();

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
            if (TxtLado.Text == "IMPAR")
                return true;
            else if (TxtLado.Text == "PAR")
                return true;
            else
            {
                MessageBox.Show("Lado incorreto");
                return false;
            }
                

            
        }
    }
}
