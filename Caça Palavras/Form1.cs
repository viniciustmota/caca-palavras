using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caça_Palavras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Coral;
            Russia.Font = new Font(Russia.Font, Russia.Font.Style | FontStyle.Strikeout );
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.Aqua;
            Panama.Font = new Font(Panama.Font, Panama.Font.Style | FontStyle.Strikeout);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.Pink;
            Suecia.Font = new Font(Suecia.Font, Suecia.Font.Style | FontStyle.Strikeout);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
            Irã.Font = new Font(Irã.Font, Irã.Font.Style | FontStyle.Strikeout);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Yellow;
            Alemanhã.Font = new Font(Alemanhã.Font, Alemanhã.Font.Style | FontStyle.Strikeout);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Green;
            Uruguai.Font = new Font(Uruguai.Font, Uruguai.Font.Style | FontStyle.Strikeout);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Brown;
            Brasil.Font = new Font(Brasil.Font, Brasil.Font.Style | FontStyle.Strikeout);

        }

        private void Russia_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGray;
            label2.BackColor = Color.LightGray;
            label3.BackColor = Color.LightGray;
            label4.BackColor = Color.LightGray;
            label5.BackColor = Color.LightGray;
            label6.BackColor = Color.LightGray;
            label7.BackColor = Color.LightGray;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
