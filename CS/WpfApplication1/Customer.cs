using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Windows;
using System.ComponentModel;

namespace WpfApplication1 {
    public class ContactItem {
        protected string _Name;
        public string Name {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public decimal Salary { get; set; }
        public DateTime Date { get; set; }
    }

}
