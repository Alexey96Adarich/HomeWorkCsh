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

namespace Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r;    // загадываем число
        int n;
        Stack<string> history = new Stack<string>();
        public MainWindow()
        {
            InitializeComponent();
            btnCommand1.Content = "+1";     // кнопка. параметры
            btnCommand2.Content = "x2";     // кнопка. параметры
            btnReset.Content = "Сброс";      /// кнопка
            lblNumber.Content = "0";       //  окно вывода инф. параметры
            lblCount.Content = "0";        //  окно вывода нажатий. параметры
            this.Title = "Удвоитель";      //название
            r = new Random();
        }
        int count;
        private void btnCommand1_Click(object sender, RoutedEventArgs e)
        {
            var t = Convert.ToInt32(lblNumber.Content);
            history.Push(t.ToString());
            if (t != n)
            {
                t += 1;
                lblNumber.Content = t.ToString();     //кнопка   +1
                count++;
                lblCount.Content = count;
            }
            if (t == n) MessageBox.Show($"ура");
        }

        private void btnCommand2_Click(object sender, RoutedEventArgs e)
        {
            var t = Convert.ToInt32(lblNumber.Content);
            history.Push(t.ToString());
            if (t != n)
            {
                t *= 2;
                lblNumber.Content = t.ToString();     //кнопка   *1
                count++;
                lblCount.Content = count;
            }
            if (t == n) MessageBox.Show($"ура");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            NewMethod();
        }
        private void NewMethod()
        {
            lblNumber.Content = "1";
            count = 0;
            lblCount.Content = count;
            n = r.Next(20, 40);
            MessageBox.Show($"Угадай {n}");
        }
        private void newGameClick(object sender, RoutedEventArgs e)   //добавили меню
        {
            NewMethod();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content = history.Pop();
        }
    }
}
