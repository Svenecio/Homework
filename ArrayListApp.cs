using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
            txt_Data.Text = Console.ReadLine();
            
        }
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //Show Data
            foreach (string data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

            MessageBox.Show("Count " + arrayList.Count.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txt_Data.Text);
            txt_Data.Text = String.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arrayList.RemoveAt(arrayList.Count - 1);
        }
    }
}
