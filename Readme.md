<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575010/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1469)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomAxisLabels/Form1.cs) (VB: [Form1.vb](./VB/CustomAxisLabels/Form1.vb))
<!-- default file list end -->
# How to individually customize axis labels


<p>Apart from the capability to customize the overall appearance of <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5804.htm">axis labels</a>, you can obtain <strong>individual</strong> axis label items at runtime. Then, it's possible to apply all the options available for axis labels to them, individually. For example, based on some criteria (e.g. an axis value threshold), you can apply different formatting to axis labels.</p><p>For this, the special <strong>CustomDrawAxisLabel</strong> event is introduced. Handle it to obtain axis labels.</p>

<br/>


