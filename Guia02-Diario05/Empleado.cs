using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppResponsive_Joseph
{
    class Empleado
    {
        private string nombre;
        private double salario;
        private string cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
