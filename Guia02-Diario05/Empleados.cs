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
    public partial class Empleados : Form
    {
        List<Empleado> listaEmpleados = new List<Empleado>();
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = txtNombre.Text;
            emp.Salario = double.Parse(txtSalario.Text);
            emp.Cargo = txtCargo.Text;
            listaEmpleados.Add(emp);

            //agregamos el objeto emp a la lista creada anteriormente
            listaEmpleados.Add(emp);
            CargarEmpleados();
        }
        private void CargarEmpleados()
        {
            //reseteamos el datagriew
            dgvEmpleados.DataSource = null;

            //mostramos la lista de empleados en el datagriwview
            dgvEmpleados.DataSource = listaEmpleados;
        }
    }
}
