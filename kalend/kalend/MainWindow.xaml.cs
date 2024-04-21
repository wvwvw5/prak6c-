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

namespace kalend
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        DateTime day = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
            plakiplaki();

        }
        
        private void plakiplaki()
        {
            plaki.Text = day.ToString("MMMM, yyyy, г."); 
            PeaceDanceDva.Children.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(day.Year, day.Month); i++)
            {
                DayCard card = new DayCard();
                card.Day = i.ToString(); 
                PeaceDanceDva.Children.Add(card);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            day = day.AddMonths(1);
            plakiplaki();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            day = day.AddMonths(-1);
            plakiplaki();
        }
    }
}

