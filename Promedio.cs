using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExam
{
    public class Promedio
    {
        public string NombreEstudainte { get; set; }
        public double Evaluacion1 { get; set; }
        public double Evaluacion2 { get; set; }
        public double Evaluacion3 { get; set; }
        public double NotaActitudinal { get; set; }

        public virtual double CalcularPromedio()
        {
            return(Evaluacion1 + Evaluacion2 + Evaluacion3 + NotaActitudinal)/4;

        }

        public virtual string Condicion()
        {
            double promedio = CalcularPromedio();
            if (promedio > 91)
            {
                return "EXCELENTE";

            }
            else if (promedio >= 81)
            {
                return "MUY BUENO";
            }
            else if (promedio >= 71)
            {
                return "BUENO";
            }
            else if (promedio >= 61)
            {
                return "REGULAR";
            }
            else if(promedio <= 60)
            {
                return "REPROBADO";
            }
            return "";
        }
        


    }

        
       
    
    
}
