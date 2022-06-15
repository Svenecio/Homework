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

namespace HelloWorldGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txt_Num01.Text);
            int y = int.Parse(txt_Num02.Text);
            int z = int.Parse(txt_Price.Text);
            txt_Ans.Text = (z / (x - y)).ToString();
            
            if(x - y <= 0)
            {
                MessageBox.Show("ใช้จ่ายให้น้อยลงนะ");
            }
        }

    }
}
