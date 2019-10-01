using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wishlist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_sumary_Click(object sender, RoutedEventArgs e)
        {
          if(txt_income.Text == "")
            {
                MessageBox.Show("กรุณากรอกรายรัยด้วยค่ะ","Error");
            }
          else if(txtout.Text == "")
            {
                MessageBox.Show("กรุณากรอกรายจ่ายด้วยค่ะ","Error");
            }
            else if (txtwant.Text == "")
            {
                MessageBox.Show("กรุณากรอก ราคาสินค้า ที่ต้องการ", "Error");
            }
          else
            {
                int income = int.Parse(txt_income.Text);
                int outcome = int.Parse(txtout.Text);
                int want = int.Parse(txtwant.Text);
                int sum = want / (income-outcome);
                txt_sum.Text = "" + sum; 
               
            }
        }
    }
}
