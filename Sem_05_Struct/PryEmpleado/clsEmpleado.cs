using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEmpleado
{
    public class clsEmpleado
    {
        public double salarioBase;
        public double comision;

        public clsEmpleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comisión ({0}, {1})", this.salarioBase, this.comision);
        }

        public void CambiarSalario(clsEmpleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
}
