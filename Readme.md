<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575010/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1469)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Chart for WinForms - How to Individually Customize Axis Labels

Apart from the capability to customize the overall appearance of [axis labels](https://docs.devexpress.com/WindowsForms/5804/controls-and-libraries/chart-control/axes/axis-labels), you can obtain individual axis labels at runtime. Then, it's possible to apply all the options available for axis labels to them, individually. You can apply different formatting to axis labels based on some criteria (for example, an axis value threshold).

For this, handle the [CustomDrawAxisLabel](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel) event to obtain axis labels.

The following image shows the resulting Chart:

![](img/customaxislabels_09789.png)

<!-- default file list -->
## Files to Review

* [Form1.cs](./CS/CustomAxisLabels/Form1.cs) (VB: [Form1.vb](./VB/CustomAxisLabels/Form1.vb))
<!-- default file list end -->

## Documentation

* [Chart Control - Axis Labels](https://docs.devexpress.com/WindowsForms/5804/controls-and-libraries/chart-control/axes/axis-labels)
* [ChartControl.CustomDrawAxisLabel](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.CustomDrawAxisLabel)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-how-to-individually-customize-axis-labels&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-charts-how-to-individually-customize-axis-labels&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
