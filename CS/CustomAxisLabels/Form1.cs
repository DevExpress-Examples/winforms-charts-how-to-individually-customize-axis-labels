using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace CustomAxisLabels {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e) {
            AxisBase axis = e.Item.Axis;
            if (axis is AxisY || axis is AxisY3D || axis is RadarAxisY) {
                double axisValue = (double)e.Item.AxisValue;
                if (axisValue < 0)
                    e.Item.TextColor = Color.Red;
                else if (axisValue > 0) {
                    e.Item.Text = "+" + e.Item.Text;
                    e.Item.TextColor = Color.Green;
                }
                else if (axisValue == 0) {
                    e.Item.Text = "Zero";
                }
            }
        }
    }
}