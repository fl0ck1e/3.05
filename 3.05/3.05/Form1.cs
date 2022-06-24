using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;

            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Value.ToLongTimeString());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label3.Text = String.Format("Вы выбрали: {0}", e.Start.ToLongDateString());
        }
    }
}
