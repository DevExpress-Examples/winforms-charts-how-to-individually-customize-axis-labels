<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomAxisLabels/Form1.cs) (VB: [Form1.vb](./VB/CustomAxisLabels/Form1.vb))
<!-- default file list end -->
# How to individually customize axis labels


<p>Apart from the capability to customize the overall appearance of <a href="http://devexpress.com/Help/Content.aspx?help=XtraCharts&document=CustomDocument5804.htm">axis labels</a>, you can obtain <strong>individual</strong> axis label items at runtime. Then, it's possible to apply all the options available for axis labels to them, individually. For example, based on some criteria (e.g. an axis value threshold), you can apply different formatting to axis labels.</p><p>For this, the special <strong>CustomDrawAxisLabel</strong> event is introduced. Handle it to obtain axis labels.</p>

<br/>


