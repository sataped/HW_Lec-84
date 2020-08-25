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

namespace Lec_84
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
        }
                        
        private void Addtxt_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(Numbertxt.Text);
            MessageBox.Show("Number : "+Numbertxt.Text);
            Numbertxt.Text = "";
        }


        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(Numbertxt.Text);
            MessageBox.Show("Remove : "+Numbertxt.Text);
            Numbertxt.Text = "";
        }

        private void Showalltxt_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show("Number: "+ data.ToString());
            }
            //Count การนับ
            MessageBox.Show("Count " + arrayList.Count.ToString());
        }
    }
}
