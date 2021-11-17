using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomAxisLabels {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        #region CustomDrawAxisLabel
        private void chartControl1_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e) {
            AxisBase axis = e.Item.Axis;
            if (axis is AxisY || axis is AxisY3D || axis is RadarAxisY) {
                double axisValue = (double)e.Item.AxisValue;
                if (axisValue < 0)
                    // Customize the axis label's color.
                    e.Item.TextColor = Color.Red;
                else if (axisValue > 0) {
                    // Customize the axis label's text and color.
                    e.Item.Text = "+" + e.Item.Text;
                    e.Item.TextColor = Color.Green;
                }
                else if (axisValue == 0) {
                    // Hide the axis labels.
                    e.Item.Text = "";
                }
            }
        }        
        #endregion
    }
}
