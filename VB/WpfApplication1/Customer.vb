Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports System.Windows
Imports System.ComponentModel

Namespace WpfApplication1
	Public Class ContactItem
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateSalary As Decimal
		Public Property Salary() As Decimal
			Get
				Return privateSalary
			End Get
			Set(ByVal value As Decimal)
				privateSalary = value
			End Set
		End Property
    End Class

End Namespace
