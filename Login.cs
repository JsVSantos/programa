using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação.DB
{
    public partial class Login : Form
    {
        Form1 Form1;
        DataTable dt = new DataTable();
        public Login(Form1 f)
        {
            InitializeComponent();
            Form1 = f;

        }

        private void btn_EsqueciSenha(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btn_LogarAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string login = txb_Usuario.Text;
            string senha = txb_Senha.Text;

            if (login == "" || senha == "")
            {
                MessageBox.Show("Usuario e ou senha está Invalido");
                txb_Usuario.Focus();
                return;
            }

            string sql = "SELECT * FROM txb_Usuario WHERE T_Usuarios='" + login + "' AND T_Senhas='" + senha + "'";
            dt = DBLoja.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario e ou senha não encontrado");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
