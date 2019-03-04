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

namespace _02_02_naive_ticket_machine_cSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cost { get; set; }
        public int balance { get; set; }
        public int total { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            cost = 100;
            
            lbl_ticketCost.Content = $"Each ticket costs {cost} .";
            txt_insertedAmount.Text = $"Insert money";
        }

                
        private void button_Click(object sender, RoutedEventArgs e)
        {
            balance += Convert.ToInt32(txt_insertedAmount.Text);
            lbl_balance.Content = balance;
            txt_insertedAmount.Text = $"Insert {cost - balance} € extra";
        }

        

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            lbl_balance.Content = balance = 0;
            txt_insertedAmount.Text = $"Insert money";
        }

        private void txt_insertedAmount_MouseEnter(object sender, MouseEventArgs e)
        {
            txt_insertedAmount.Text = "";
        }

       
    }
}
