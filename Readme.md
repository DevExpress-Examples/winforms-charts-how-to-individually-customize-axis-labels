<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575010/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1469)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to individually customize axis labels

Apart from the capability to customize the overall appearance of [axis labels](https://docs.devexpress.com/WindowsForms/5804/controls-and-libraries/chart-control/axes/axis-labels), you can obtain individual axis labels at runtime. Then, it's possible to apply all the options available for axis labels to them, individually. You can apply different formatting to axis labels based on some criteria (for example, an axis value threshold).

For this, handle the [CustomDrawAxisLabel](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel) event to obtain axis labels.

The following image shows the resulted Chart:

![](img/customaxislabels_09789.png)

<!-- default file list -->
## Files to Look At

* [Form1.cs](./CS/CustomAxisLabels/Form1.cs) (VB: [Form1.vb](./VB/CustomAxisLabels/Form1.vb))
<!-- default file list end -->

## Documentation

* [Chart Control - Axis Labels](https://docs.devexpress.com/WindowsForms/5804/controls-and-libraries/chart-control/axes/axis-labels)
* [ChartControl.CustomDrawAxisLabel](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel)
