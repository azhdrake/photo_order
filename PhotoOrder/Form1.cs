using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoOrder
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      cmbSizes.Items.Add("Small");
      cmbSizes.Items.Add("Medium");
      cmbSizes.Items.Add("Large");

      cmbSizes.SelectedIndex = 0;
    }

    private void buttCalc_Click(object sender, EventArgs e)
    {
      String itemSize = cmbSizes.SelectedItem.ToString();

      double price;

      switch (itemSize){
        case "Small":
          price = 0.20;
          break;
        case "Medium":
          price = 0.40;
          break;
        case "Large":
          price = 0.60;
          break;
        default:
          MessageBox.Show("Please pick a size.", "Error");
          return;

          txtPrice.Text = price.ToString("c");
      } 
    }
  }
}
