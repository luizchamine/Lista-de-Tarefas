using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITarefa
{
    public partial class FormTarefa : Form
    {
        public FormTarefa()
        {
            InitializeComponent();
        }

        private void tarefaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTarefa_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            using (FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                    Application.Exit();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
            TarefaBLL tarefaBLL = new TarefaBLL();
            tarefaBindingSource.DataSource = tarefaBLL.Buscar(textBoxBuscar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastrarTarefa frm = new FormCadastrarTarefa())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Certeza em excluir essa tarefa?","",MessageBoxButtons.YesNo)== DialogResult.No)
                    return;
                TarefaBLL tarefaBLL = new TarefaBLL();
                int id = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id"]);
                tarefaBLL.Excluir(id);
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
