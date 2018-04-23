using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Xpf.Grid;
using System.Windows.Threading;
using DevExpress.Xpf.Editors.Settings;
using System.Threading;
using DevExpress.Data;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        List<ContactItem> coll;
        public Window1() {
            InitializeComponent();
            coll = new List<ContactItem>();
            ContactItem f1 = new ContactItem();
            f1.Name = "Abcd";
            f1.Salary = 13.40m;
            f1.Date = DateTime.Now;
            coll.Add(f1);
            ContactItem f2 = new ContactItem();
            f2.Name = "bla1";
            f2.Date = DateTime.Now;
            f2.Salary = 13;

            coll.Add(f2);

            ContactItem f3 = new ContactItem();
            f3.Name = "la";
            f3.Salary = 13;

            coll.Add(f3);

            ContactItem f4 = new ContactItem();
            f4.Name = " bla";
            f4.Salary = 13;

            coll.Add(f4);

            gridControl1.DataSource = coll;
            

        }
    }
    
    public static class PasswordHelper {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password",
            typeof(string), typeof(PasswordHelper),
            new FrameworkPropertyMetadata(string.Empty, OnPasswordPropertyChanged));

        public static readonly DependencyProperty AttachProperty =
            DependencyProperty.RegisterAttached("Attach",
            typeof(bool), typeof(PasswordHelper), new PropertyMetadata(false, Attach));

        private static readonly DependencyProperty IsUpdatingProperty =
           DependencyProperty.RegisterAttached("IsUpdating", typeof(bool),
           typeof(PasswordHelper));


        public static void SetAttach(DependencyObject dp, bool value) {
            dp.SetValue(AttachProperty, value);
        }

        public static bool GetAttach(DependencyObject dp) {
            return (bool)dp.GetValue(AttachProperty);
        }

        public static string GetPassword(DependencyObject dp) {
            return (string)dp.GetValue(PasswordProperty);
        }

        public static void SetPassword(DependencyObject dp, string value) {
            dp.SetValue(PasswordProperty, value);
        }

        private static bool GetIsUpdating(DependencyObject dp) {
            return (bool)dp.GetValue(IsUpdatingProperty);
        }

        private static void SetIsUpdating(DependencyObject dp, bool value) {
            dp.SetValue(IsUpdatingProperty, value);
        }

        private static void OnPasswordPropertyChanged(DependencyObject sender,
            DependencyPropertyChangedEventArgs e) {
            PasswordBox passwordBox = sender as PasswordBox;
            passwordBox.PasswordChanged -= PasswordChanged;

            if (!(bool)GetIsUpdating(passwordBox)) {
                passwordBox.Password = (string)e.NewValue;
            }
            passwordBox.PasswordChanged += PasswordChanged;
        }

        private static void Attach(DependencyObject sender,
            DependencyPropertyChangedEventArgs e) {
            PasswordBox passwordBox = sender as PasswordBox;

            if (passwordBox == null)
                return;

            if ((bool)e.OldValue) {
                passwordBox.PasswordChanged -= PasswordChanged;
            }

            if ((bool)e.NewValue) {
                passwordBox.PasswordChanged += PasswordChanged;
            }
        }

        private static void PasswordChanged(object sender, RoutedEventArgs e) {
            PasswordBox passwordBox = sender as PasswordBox;
            SetIsUpdating(passwordBox, true);
            SetPassword(passwordBox, passwordBox.Password);
            SetIsUpdating(passwordBox, false);
        }
    }

}
