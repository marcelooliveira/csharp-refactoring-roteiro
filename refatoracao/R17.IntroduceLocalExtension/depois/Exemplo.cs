using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R17.IntroduceLocalExtension.depois
{
    class Exemplo
    {
        public Exemplo()
        {
            var data = DateTime.Today;
            var ultimoDiaDoMes = data.UltimoDiaDoMes();
        }

    }

    static class DateTimeExtensions
    {
        public static DateTime UltimoDiaDoMes(this DateTime data)
        {
            return new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
        }
    }
}
