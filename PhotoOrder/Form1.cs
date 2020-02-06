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
      // Set up the combo box
      cmbSizes.Items.Add("Small");
      cmbSizes.Items.Add("Medium");
      cmbSizes.Items.Add("Large");

      cmbSizes.SelectedIndex = 0;
    }

    private void buttCalc_Click(object sender, EventArgs e)
    {
      String itemSize = cmbSizes.SelectedItem.ToString();

      double price;

      // It's a switch statement! It's like an if statement! But it's syntactiacally slightly different! I'm not looking up how to actually spell syntactically!
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
      }
      txtPrice.Text = price.ToString("c");
    }
  }
}
