using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace VisualDice
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dicetwo.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dicetwo.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int one = rnd.Next(1,7);
            int two = rnd.Next(1,7);
            switch (one)
            {
                case 1:
                    diceone.Source = new BitmapImage(new Uri(@"Dices\dice_one.png", UriKind.Relative));
                    break;
                case 2:
                    diceone.Source = new BitmapImage(new Uri(@"Dices\dice_two.png", UriKind.Relative));
                    break;
                case 3:
                    diceone.Source = new BitmapImage(new Uri(@"Dices\dice_three.png", UriKind.Relative));
                    break;
                case 4:
                    diceone.Source = new BitmapImage(new Uri(@"Dices\dice_four.png", UriKind.Relative));
                    break;
                case 5:
                    diceone.Source = new BitmapImage(new Uri(@"Dices\dice_five.png", UriKind.Relative));
                    break;
                case 6:
                    diceone.Source = new BitmapImage(new Uri(@"Dices\dice_six.png", UriKind.Relative));
                    break;
            }
            switch (two)
            {
                case 1:
                    dicetwo.Source = new BitmapImage(new Uri(@"Dices\dice_one.png", UriKind.Relative));
                    break;
                case 2:
                    dicetwo.Source = new BitmapImage(new Uri(@"Dices\dice_two.png", UriKind.Relative));
                    break;
                case 3:
                    dicetwo.Source = new BitmapImage(new Uri(@"Dices\dice_three.png", UriKind.Relative));
                    break;
                case 4:
                    dicetwo.Source = new BitmapImage(new Uri(@"Dices\dice_four.png", UriKind.Relative));
                    break;
                case 5:
                    dicetwo.Source = new BitmapImage(new Uri(@"Dices\dice_five.png", UriKind.Relative));
                    break;
                case 6:
                    dicetwo.Source = new BitmapImage(new Uri(@"Dices\dice_six.png", UriKind.Relative));
                    break;
            }
        }
    }
}
