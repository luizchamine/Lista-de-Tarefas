using BLL;
using Model;
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

namespace UITarefa
{
    public partial class FormCadastrarTarefa : Form
    {
        public FormCadastrarTarefa()
        {
            InitializeComponent();
        }

        private void FormCadastrarTarefa_Load(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            TarefaBLL tarefaBLL = new TarefaBLL();
            Tarefa tarefa = new Tarefa();
            tarefa.Id = Convert.ToInt32(idTextBox.Text);
            tarefa.Descricao = descricaoTextBox.Text;
            tarefa.Estatus = estatusTextBox.Text;
            tarefa.Id_Usuario = 1;
            tarefaBLL.Inserir(tarefa);
            MessageBox.Show("Tarefa adicionada!");
            Close();
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {

        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
