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

namespace HashTableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
            txt_Key.Text = Console.ReadLine();
            txt_Value.Text = Console.ReadLine();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(txt_Key.Text, txt_Value.Text);
            txt_Key.Text = String.Empty;
            txt_Value.Text = String.Empty;
            
        }

        private void removebtn_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(txt_Key.Text);
            txt_Key.Text = String.Empty;
        }

        private void ShowAllbtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //Show all
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
