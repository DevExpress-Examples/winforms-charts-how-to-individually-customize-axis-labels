<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomAxisLabels/Form1.cs) (VB: [Form1.vb](./VB/CustomAxisLabels/Form1.vb))
<!-- default file list end -->
# How to individually customize axis labels

Apart from the capability to customize the overall appearance of [axis labels](https://docs.devexpress.com/WindowsForms/5804/controls-and-libraries/chart-control/axes/axis-labels?p=netframework), you can obtain **individual** axis label items at runtime. Then, it's possible to apply all the options available for axis labels to them, individually. For example, based on some criteria (for example, an axis value threshold), you can apply different formatting to axis labels.

For this, handle the [CustomDrawAxisLabel](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel?p=netframework) event to obtain axis labels.
