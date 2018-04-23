Imports Microsoft.VisualBasic
Imports System
Namespace CustomAxisLabels
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {CType(-12.0R, Object)})
            Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {CType(-2.0R, Object)})
            Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {CType(3.0R, Object)})
            Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {CType(8.0R, Object)})
            Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            XyDiagram2.AxisX.Label.Visible = False
            XyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram2.AxisX.Range.SideMarginsEnabled = True
            XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram2.AxisY.Label.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            XyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            XyDiagram2.AxisY.Range.SideMarginsEnabled = True
            XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = XyDiagram2
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            PointSeriesLabel3.LineVisible = True
            Series2.Label = PointSeriesLabel3
            Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Series2.Name = "Series 1"
            Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8})
            Series2.View = LineSeriesView3
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
            PointSeriesLabel4.LineVisible = True
            Me.chartControl1.SeriesTemplate.Label = PointSeriesLabel4
            Me.chartControl1.SeriesTemplate.View = LineSeriesView4
            Me.chartControl1.Size = New System.Drawing.Size(524, 308)
            Me.chartControl1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(524, 308)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

