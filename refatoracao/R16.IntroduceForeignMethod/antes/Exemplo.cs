using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R16.IntroduceForeignMethod.antes
{
    class Exemplo
    {
        public Exemplo()
        {
            var data = DateTime.Today;
            UltimoDiaDoMes(data);
        }

        private static void UltimoDiaDoMes(DateTime data)
        {
            var ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
        }
    }
}
