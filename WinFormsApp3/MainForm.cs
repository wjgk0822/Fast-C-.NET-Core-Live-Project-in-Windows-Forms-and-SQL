using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.Year_num_lbl.Text=System.DateTime.Now.Year.ToString();
            //int mn = System.DateTime.Now.Month;
            //string month_name;
            
            //month_name=System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
            //this.month_name_lbl.Text = month_name;
            //this.day_month_lbl.Text=System.DateTime.Now.Day.ToString();
            //this.day_week_lbl.Text=System.DateTime.Now.DayOfWeek.ToString();
            //----------------------load date--------------
            get_date_cal();

            //-----------------Tree view----------------

            this.tree_panel.Visible = false;

            this.main_Tree_view.ExpandAll();


        }

        void get_date_cal()
        {
            this.Year_num_lbl.Text = System.DateTime.Now.Year.ToString();
            int mn = System.DateTime.Now.Month;
            string month_name;

            month_name = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
            this.month_name_lbl.Text = month_name;
            this.day_month_lbl.Text = System.DateTime.Now.Day.ToString();
            this.day_week_lbl.Text = System.DateTime.Now.DayOfWeek.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.analogClock1.Time= System.DateTime.Now;
        }

        private void Data_entry_btn_Click(object sender, EventArgs e)
        {
            this.tree_panel.Visible =! this.tree_panel.Visible;


        }

        private void expand_btn_Click(object sender, EventArgs e)
        {
            this.main_Tree_view.ExpandAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_Tree_view.CollapseAll();
        }
    }
}
