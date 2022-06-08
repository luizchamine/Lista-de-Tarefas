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
    public partial class FormLogin : Form
    {
        public bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                BindingSource usuarioBindingSource = new BindingSource();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorNome(textBoxUsuario.Text);

                if (usuarioBindingSource.Count != 0)
                {

                    string nome = ((DataRowView)usuarioBindingSource.Current).Row["Nome"].ToString();
                    string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();
                    if (nome != textBoxUsuario.Text)
                    {
                        MessageBox.Show("incorreto!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }
                    if (senha != textBoxSenha.Text)
                    {
                        MessageBox.Show("errado!");
                        //textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }
                    if (nome == textBoxUsuario.Text && senha == textBoxSenha.Text)
                    {
                        Logou = true;
                        MessageBox.Show("Login permitido!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Login negado!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado no banco de dados!");
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
