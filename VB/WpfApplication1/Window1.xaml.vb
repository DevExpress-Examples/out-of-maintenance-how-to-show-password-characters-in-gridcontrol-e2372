Imports Microsoft.VisualBasic
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
Imports DevExpress.Wpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Wpf.Editors.Settings
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

			coll.Add(f1)
			Dim f2 As New ContactItem()
			f2.Name = "bla1"

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

			gridControl1.DataSource = coll


		End Sub
	End Class

    Public NotInheritable Class PasswordHelper
        Private Sub New()
        End Sub

        Public Shared ReadOnly PasswordProperty As DependencyProperty = DependencyProperty.RegisterAttached("Password", GetType(String), GetType(PasswordHelper), New FrameworkPropertyMetadata(String.Empty, New PropertyChangedCallback(AddressOf OnPasswordPropertyChanged)))

        Public Shared ReadOnly AttachProperty As DependencyProperty = DependencyProperty.RegisterAttached("Attach", GetType(Boolean), GetType(PasswordHelper), New PropertyMetadata(False, New PropertyChangedCallback(AddressOf Attach)))

        Private Shared ReadOnly IsUpdatingProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsUpdating", GetType(Boolean), GetType(PasswordHelper))


        Public Shared Sub SetAttach(ByVal dp As DependencyObject, ByVal value As Boolean)
            dp.SetValue(AttachProperty, value)
        End Sub

        Public Shared Function GetAttach(ByVal dp As DependencyObject) As Boolean
            Return CBool(dp.GetValue(AttachProperty))
        End Function

        Public Shared Function GetPassword(ByVal dp As DependencyObject) As String
            Return DirectCast(dp.GetValue(PasswordProperty), String)
        End Function

        Public Shared Sub SetPassword(ByVal dp As DependencyObject, ByVal value As String)
            dp.SetValue(PasswordProperty, value)
        End Sub

        Private Shared Function GetIsUpdating(ByVal dp As DependencyObject) As Boolean
            Return CBool(dp.GetValue(IsUpdatingProperty))
        End Function

        Private Shared Sub SetIsUpdating(ByVal dp As DependencyObject, ByVal value As Boolean)
            dp.SetValue(IsUpdatingProperty, value)
        End Sub

        Private Shared Sub OnPasswordPropertyChanged(ByVal sender As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            Dim passwordBox As PasswordBox = TryCast(sender, PasswordBox)
            RemoveHandler passwordBox.PasswordChanged, AddressOf PasswordChanged

            If Not CBool(GetIsUpdating(passwordBox)) Then
                passwordBox.Password = DirectCast(e.NewValue, String)
            End If
            AddHandler passwordBox.PasswordChanged, AddressOf PasswordChanged
        End Sub

        Private Shared Sub Attach(ByVal sender As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            Dim passwordBox As PasswordBox = TryCast(sender, PasswordBox)

            If passwordBox Is Nothing Then
                Return
            End If

            If CBool(e.OldValue) Then
                RemoveHandler passwordBox.PasswordChanged, AddressOf PasswordChanged
            End If

            If CBool(e.NewValue) Then
                AddHandler passwordBox.PasswordChanged, AddressOf PasswordChanged
            End If
        End Sub

        Private Shared Sub PasswordChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim passwordBox As PasswordBox = TryCast(sender, PasswordBox)
            SetIsUpdating(passwordBox, True)
            SetPassword(passwordBox, passwordBox.Password)
            SetIsUpdating(passwordBox, False)
        End Sub
    End Class
End Namespace
