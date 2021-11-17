Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomAxisLabels

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub chartControl1_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
            Dim axis As AxisBase = e.Item.Axis
            If TypeOf axis Is AxisY OrElse TypeOf axis Is AxisY3D OrElse TypeOf axis Is RadarAxisY Then
                Dim axisValue As Double = CDbl(e.Item.AxisValue)
                If axisValue < 0 Then
                    e.Item.TextColor = Color.Red
                ElseIf axisValue > 0 Then
                    e.Item.Text = "+" & e.Item.Text
                    e.Item.TextColor = Color.Green
                ElseIf axisValue = 0 Then
                    e.Item.Text = "Zero"
                End If
            End If
        End Sub
    End Class
End Namespace
