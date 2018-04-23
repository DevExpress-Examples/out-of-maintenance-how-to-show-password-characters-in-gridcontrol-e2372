Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Xpf.Editors.Settings
Imports System.Threading
Imports DevExpress.Data

Namespace WpfApplication1
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class Window1
        Inherits Window

        Private coll As List(Of ContactItem)
        Public Sub New()
            InitializeComponent()
            coll = New List(Of ContactItem)()
            Dim f1 As New ContactItem()
            f1.Name = "Abcd"
            f1.Salary = 13.40D
            f1.Date = Date.Now
            coll.Add(f1)
            Dim f2 As New ContactItem()
            f2.Name = "bla1"
            f2.Date = Date.Now
            f2.Salary = 13

            coll.Add(f2)

            Dim f3 As New ContactItem()
            f3.Name = "la"
            f3.Salary = 13

            coll.Add(f3)

            Dim f4 As New ContactItem()
            f4.Name = " bla"
            f4.Salary = 13

            coll.Add(f4)

            gridControl1.ItemsSource = coll


        End Sub
    End Class


End Namespace
