using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppResponsive_Joseph
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.Show();
        }
    }
}
