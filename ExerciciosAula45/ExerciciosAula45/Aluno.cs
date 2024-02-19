using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosAula45
{
    internal class Aluno
    {
        public string Nome;
        public double NotaTrimestre1;
        public double NotaTrimestre2;
        public double NotaTrimestre3;

        public double NotaFinal()
        {
            return NotaTrimestre1 + NotaTrimestre2 + NotaTrimestre3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Diferenca()
        {
            if (Aprovado() == false)
            {
                return 60 - NotaFinal();
            }
            else
            {
                return 0;
            }
        }
    }
}
