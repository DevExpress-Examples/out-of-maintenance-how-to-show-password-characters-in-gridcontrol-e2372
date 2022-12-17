Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.ComponentModel

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Private coll As List(Of ContactItem)

        Public Sub New()
            Me.InitializeComponent()
            coll = New List(Of ContactItem)()
            Dim f1 As ContactItem = New ContactItem()
            f1.Name = "Abcd"
            f1.Salary = 13.40D
            f1.Date = Date.Now
            coll.Add(f1)
            Dim f2 As ContactItem = New ContactItem()
            f2.Name = "bla1"
            f2.Date = Date.Now
            f2.Salary = 13
            coll.Add(f2)
            Dim f3 As ContactItem = New ContactItem()
            f3.Name = "la"
            f3.Salary = 13
            coll.Add(f3)
            Dim f4 As ContactItem = New ContactItem()
            f4.Name = " bla"
            f4.Salary = 13
            coll.Add(f4)
            Me.gridControl1.ItemsSource = coll
        End Sub
    End Class
End Namespace
