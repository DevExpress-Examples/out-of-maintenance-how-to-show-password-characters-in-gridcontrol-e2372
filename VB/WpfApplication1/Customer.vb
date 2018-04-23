Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports System.Windows
Imports System.ComponentModel

Namespace WpfApplication1
    Public Class ContactItem
        Protected _Name As String
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(ByVal value As String)
                Me._Name = value
            End Set
        End Property
        Public Property Salary() As Decimal
        Public Property [Date]() As Date
    End Class

End Namespace
