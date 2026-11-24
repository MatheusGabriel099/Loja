using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Frm_Loja : Form
    {
        double bicicleta, calculadora, camera, cd, celular, churrasqueira, despertador, micro;

        private void Num_P1_ValueChanged(object sender, EventArgs e)
        {
            q1 = (double)Num_P1.Value;
            Lbl_E1.Text = "Dísponivel: " + (e1 - q1);
            total();
        }

        private void Chk_P2_CheckedChanged(object sender, EventArgs e)
        {
            calculadora = 25;
            e2 = 20;

            if (Chk_P2.Checked ==true)
            {
                Chk_P2.Text = "Calculadora";
                Pic2.Image = Properties.Resources.Calculadora;
                ListProdutos.Items.Add("Calculadora");
                ListDescricao.Items.Add("Comercial Eletrônica 12 Dígitos");
                ListPreco.Items.Add(calculadora);
                Num_P2.Visible = true;
                Num_P2.Maximum = e2;
            }
            else
            {
                Chk_P2.Text = "Calculadora";
                Pic2.Image = Properties.Resources.Produto;
                ListProdutos.Items.Remove("Calculadora");
                ListDescricao.Items.Remove("Comercial Eletrônica 12 Dígitos");
                ListPreco.Items.Remove(calculadora);
                Num_P2.Visible = false;
                Num_P2.Maximum = 0;
            }

        }

        private void Num_P2_ValueChanged(object sender, EventArgs e)
        {
            q2 = (double)Num_P2.Value;
            Lbl_E2.Text = "Dísponivel: " + (e2 - q2);
            total();
        }

        private void Chk_P3_CheckedChanged(object sender, EventArgs e)
        {
            camera = 3000;
            e3 = 7;

            if (Chk_P3.Checked ==true)
            {
                Chk_P3.Text = "Câmera";
                Pic3.Image = Properties.Resources.Camera_Fotografica_PNG_Transparente;
                ListProdutos.Items.Add("Câmera");
                ListDescricao.Items.Add("Nikon Compacta");
                ListPreco.Items.Add(camera);
                Num_P3.Visible = true;
                Num_P3.Maximum = e3;
            }
            else
            {
                Chk_P3.Text = ("Câmera");
                Pic3.Image = Properties.Resources.Produto;
                ListProdutos.Items.Remove("Câmera");
                ListDescricao.Items.Remove("Nikon Compacta");
                ListPreco.Items.Remove(camera);
                Num_P3.Visible = false;
                Num_P3.Maximum = 0;
            }
        }

        private void Num_P3_ValueChanged(object sender, EventArgs e)
        {
            q3 = (double)Num_P3.Value;
            Lbl_E3.Text = "Dísponivel: " + (e3 - q3);
            total();
        }

        private void Chk_P4_CheckedChanged(object sender, EventArgs e)
        {
            cd = 5.00;
            e4 = 65;

            if (Chk_P4.Checked ==true)
            {
                Chk_P4.Text = "CD";
                Pic4.Image = Properties.Resources.CD_png;
                ListProdutos.Items.Add("CD");
                ListDescricao.Items.Add("MaxPrint 700MB");
                ListPreco.Items.Add(cd);
                Num_P4.Visible = true;
                Num_P4.Maximum = e4;
            }
            else
            {
                Chk_P4.Text = "CD";
                Pic4.Image = Properties.Resources.Produto;
                ListProdutos.Items.Remove("CD");
                ListDescricao.Items.Remove("MaxPrint 700MB");
                ListPreco.Items.Remove(cd);
                Num_P4.Visible = false;
                Num_P4.Maximum = 0;

            }
        }

        private void Num_P4_ValueChanged(object sender, EventArgs e)
        {
            q4 = (double)Num_P4.Value;
            Lbl_E4.Text = "Dísponivel: " + (e4 - q4);
            total();
        }

        private void Chk_P5_CheckedChanged(object sender, EventArgs e)
        {
            celular = 2500.00;
            e5 = 15;

            if (Chk_P5.Checked ==true)
            {
                Chk_P5.Text = "Celular";
                Pic5.Image = Properties.Resources.Celular_PNG_Transparente;
                ListProdutos.Items.Add("Celular");
                ListDescricao.Items.Add("64GB - iOS - Impressão Digital");
                ListPreco.Items.Add(celular);
                Num_P5.Visible = true;
                Num_P5.Maximum = e5;
            }
            else
            {
                Chk_P5.Text = "Celular";
                Pic5.Image = Properties.Resources.Produto;
                ListProdutos.Items.Remove("Celular");
                ListDescricao.Items.Remove("64GB - iOS - Impressão Digital");
                ListPreco.Items.Remove(celular);
                Num_P5.Visible = false;
                Num_P5.Maximum = 0;
            }
        }

        private void Chk_P6_CheckedChanged(object sender, EventArgs e)
        {
            churrasqueira = 160.00;
            e6 = 8;

            if (Chk_P6.Checked ==true)
            {
                Chk_P6.Text = "Churrasqueira";
                Pic6.Image = Properties.Resources.Churrasqueira_em_Tijolinho_Cinza_com_Chamine_e_Grelha_PNG_Transparente;
                ListProdutos.Items.Add("Churrasqueira");
                ListDescricao.Items.Add("Portátil");
                ListPreco.Items.Add(churrasqueira);
                Num_P6.Visible = true;
                Num_P6.Maximum = e6;
            }
            else
            {
                Chk_P6.Text = "Churrasqueira";
                Pic6.Image = Properties.Resources.Produto;
                ListProdutos.Items.Remove("Churrasqueira");
                ListDescricao.Items.Remove("Portátil");
                ListPreco.Items.remobe(churrasqueira);
                Num_P6.Visible = false;
                Num_P6.Maximum = 0;

            }
        }

        private void Num_P6_ValueChanged(object sender, EventArgs e)
        {
            q5 = (double)Num_P5.Value;
            Lbl_E5.Text = "Dísponivel: " + (e5 - q5);
            total();
        }

        private void Grp_ListCompra_Enter(object sender, EventArgs e)
        {

        }

        private void Chk_P7_CheckedChanged(object sender, EventArgs e)
        {
            despertador = 50.00;
            e7 = 10;

            if (Chk_P7.Checked ==true)
            {
                Chk_P7.Text = "Despertador";
                Pic7.Image = Properties.Resources.pngwing_com;

            }
        }

        int e1, e2, e3, e4, e5, e6, e7, e8;
        double q1, q2, q3, q4, q5, q6, q7, q8;

        public Frm_Loja()
        {
            InitializeComponent();
        }

        private void total()
        {
            Lbl_Total2.Text = ((bicicleta * q1) + (calculadora * q2) + (camera * q3) + (cd * q4) + (celular + q5) + (churrasqueira * q6) + (despertador * q7) + (micro * q8).ToString("c2"));
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            q5 = (double)Num_P5.Value;
            Lbl_E5.Text = "Dísponivel: " + (e5 - q5);
            total();
        }

        private void Frm_Loja_Load(object sender, EventArgs e)
        {

        }

        private void Chk_P1_CheckedChanged(object sender, EventArgs e)
        {
            bicicleta = 500;
            e1 = 10;

            if (Chk_P1.Checked ==true)
            {
                Chk_P1.Text = "Bicicleta";
                Pic1.Image = Properties.Resources.Bicicleta2;
                ListProdutos.Items.Add("Bicicleta");
                ListDescricao.Items.Add("Aro 26 Caloi");
                ListPreco.Items.Add(bicicleta);
                Num_P1.Visible = true;
                Num_P1.Maximum = e1;
            }
            else
            {
                Chk_P1.Text = "Bicicleta";
                Pic1.Image = Properties.Resources.Produto;
                ListProdutos.Items.Remove("Bicicleta");
                ListDescricao.Items.Remove("Aro 26 Caloi");
                ListPreco.Items.Remove(bicicleta);
                Num_P1.Visible = false;
                Num_P1.Maximum = 0;

            }
        }
    }
}
