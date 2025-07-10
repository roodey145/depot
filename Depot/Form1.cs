using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addItem1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(itemName.Text);
            
            string productId=productNumberTxt.Text;
            string productName = productNameTxt.Text;
            string bundlePiecesText = bundlePiecesTxt.Text;
            string numberOfBundlesText = numberOfBundlesTxt.Text;
            string piecesText = piecesTxt.Text;
            string priceText = priceTxt.Text;

        }

        private void bundlePiecesTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
