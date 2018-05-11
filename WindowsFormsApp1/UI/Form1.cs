using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AreaBLL areaBLL = new AreaBLL();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = areaBLL.LoadProvinceData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area area = comboBox1.SelectedItem as Area;
            int id = area.AreaId;
            comboBox2.DataSource = areaBLL.LoadCityData(id);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area area = comboBox2.SelectedItem as Area;
            int id = area.AreaId;
            comboBox3.DataSource = areaBLL.LoadCountyData(id);
        }
    }
}
