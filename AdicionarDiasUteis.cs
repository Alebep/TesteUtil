using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitariiosDiasUteisEeStringNetFramework
{
    public class AdicionarDiasUteis
    {
        static public DateTime AdicionaDiasUteisAaData(DateTime pDataInicial, int pDias)
        {
            DateTime resultado = pDataInicial;

            while (pDias > -1)
            {
                //Se é sábado, domingo ou feriado, ando um dia pra frente
                if (resultado.DayOfWeek == DayOfWeek.Saturday || resultado.DayOfWeek == DayOfWeek.Sunday /*|| feriados.Contains(resultado) uso se houver uma funcao q verifica os feriados*/)
                {
                    resultado = resultado.AddDays(1);
                }
                //Ou se quiser adicionar um dia útil (X horas trabalhadas = 1 dia útil)
                else if (pDias > 0)
                {
                    resultado = resultado.AddDays(1);
                    pDias -= 1;
                }
                //Se a data final for no fim de semana ou feriado
                else if (pDias == 0)
                {
                    while (resultado.DayOfWeek == DayOfWeek.Saturday || resultado.DayOfWeek == DayOfWeek.Sunday/*|| feriados.Contains(resultado)*/)
                    {
                        resultado = resultado.AddDays(1);
                    }
                    pDias = -1;
                }
            }

            return resultado;
        }
    }
}
