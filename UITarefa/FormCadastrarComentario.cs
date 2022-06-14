using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UITarefa
{
    public partial class FormCadastrarComentario : Form
    {
        public FormCadastrarComentario()
        {
            InitializeComponent();
        }

        private void FormCadastrarComentario_Load(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ComentarioBLL comentarioBLL = new ComentarioBLL();
                Comentario comentario = new Comentario();
                comentario.Id = Convert.ToInt32(idTextBox.Text);
                comentario.Descricao = descricaoTextBox.Text;
                comentarioBLL.Inserir(comentario);
                MessageBox.Show("Comentário adicionado!");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
