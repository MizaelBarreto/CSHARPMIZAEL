using CelularCTI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelularCTI.Desktop
{
    public partial class frmCompra : Form
    {
        private Aparelho ap;
        public frmCompra(Aparelho ap)
        {
            

            InitializeComponent();
            this.ap = ap;

            Lbl_ExibModel.Text= ap.Modelo.ToString();
            Lbl_ExibLargura.Text= ap.Largura.ToString();
            Lbl_ExibFab.Text= ap.Fabricante.Nome;
            Lbl_ExibDesc.Text = ap.Desconto.ToString();
            Lbl_ExibPreco.Text = ap.Preco.ToString();
            Lbl_ExibiId.Text = ap.Id_Aparelho.ToString();
            Lbl_ExibAlt.Text = ap.Altura.ToString();
            Lbl_ExibQuant.Text = ap.Quantidade.ToString();
            Lbl_exibPeso.Text = ap.Peso.ToString();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            ap.Quantidade -= 1;
            Servico.Salvar(ap);
            MessageBox.Show("Aparelho comprado com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

     
     
    }
}
