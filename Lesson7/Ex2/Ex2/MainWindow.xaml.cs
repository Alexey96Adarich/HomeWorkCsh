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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r;    // загадываем число
        int n;     // сгенерированное
        int a;      // введеное
        int count = 6;
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Угадай число";      //название проекта
            r = new Random();
        }

        private void guy_Click(object sender, RoutedEventArgs e)
        {
            n = r.Next(1, 100);
            MessageBox.Show($"Угадай загаданное число от 1 до 100. У вас " + count + " попытки");       
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(play.Text);   // вызываем текст
            if (a == n)
            {
                MessageBox.Show($"Ура! Компьютер загадал число {n}");
            }
            else if (n > a)
            {
                MessageBox.Show($"Загаданное число больше, попытка № " + (count - 1) /*(count.Length - 1)*/);
                count--;
            }
            else if (n < a)
            {
                MessageBox.Show($"Загаданное число меньше, попытка № " + (count - 1));
                count--;
            }
            if (count == 0)
            {
                MessageBox.Show($"Увы, вы не отгадали загаданное число. Это было число " + n);
                Close();
            }
        }
    }
}
