using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDadoscomCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoProjectDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.bancoProjectDataSet.Pessoa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.MovePrevious();
                }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.EndEdit();
            pessoaTableAdapter.Update(bancoProjectDataSet);
        }
    }
}
