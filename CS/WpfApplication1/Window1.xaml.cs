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
    

}
