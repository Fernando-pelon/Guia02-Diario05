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
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleados fe = new Empleados();
            fe.Show();
            //le indicamos que este pendiente por si formEmpleados se cierra
            fe.FormClosed += delegate
            {
                this.Show();
            };

            this.Hide();
        }
    }
}
