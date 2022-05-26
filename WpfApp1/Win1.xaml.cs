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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Win1 : Window
    {
        public static UsersEntities _context = new UsersEntities();
        User _user = new User();

        public Win1()
        {
            InitializeComponent();
            id.ItemsSource = _context.User.ToList();
        }

        void Clear()
        {
            Name.Text = null;
            Password.Text = null;
            Status.Text = null;
            MessageBox.Show("Готово!");
            _context.SaveChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _win = new MainWindow();
            this.Close();
            _win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int n = 0;
            if (id.Text == "") MessageBox.Show("Выберите ИД!");
            foreach (var item in _context.User)
            {
                _user = item;
                n = 1;
            }

            if (n == 1)
            {
                Name.Text = _user.Name;
                Password.Text = _user.Password;
                Status.Text = _user.Status;
            }
        }

        private void del_b_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            foreach (var item in _context.User)
            {
                if (item.ID.ToString() == id.Text) 
                {
                        _user = item;
                        n = 1;
                }
            }
            if (n == 1)
            {
                _context.User.Remove(_user);
                Name.IsReadOnly = true;
                Password.IsReadOnly = true;
                Status.IsReadOnly = true;
                Clear();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            choise.Visibility = Visibility.Hidden;
            del_b.Visibility = Visibility.Visible;
            data.Visibility = Visibility.Visible;
            res.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            choise.Visibility = Visibility.Hidden;
            add_b.Visibility = Visibility.Visible;
            data.Visibility = Visibility.Visible;
        }

        private void add_b_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" & Password.Text == "" & Status.Text == "") MessageBox.Show("Введите данные!");
            else
            {
                _user.Name = Name.Text;
                _user.Password = Password.Text;
                _user.Status = Status.Text;
                _context.User.Add(_user);
                Clear();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            choise.Visibility = Visibility.Hidden;
            save_b.Visibility = Visibility.Visible;
            data.Visibility = Visibility.Visible;
            res.Visibility = Visibility.Visible;
        }

        private void save_b_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            if (Name.Text == "" & Password.Text == "" & Status.Text == "") MessageBox.Show("Введите данные!");

            foreach (var item in _context.User)
            {
                if (item.ID.ToString() == id.Text)
                {
                    _user = item;
                    n = 1;
                }
            }

            if (n == 1)
            {
                _user.Name = Name.Text;
                _user.Password = Password.Text;
                _user.Status = Status.Text;
                Clear();
            }
        }
    }
}
