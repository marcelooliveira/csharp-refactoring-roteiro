using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R32.DecomposeConditional.antes
{
    class HotelFazenda
    {
        private decimal _taxaInverno;
        private decimal _taxaServicoInverno;
        private decimal _taxaVerao;
        private DateTime INICIO_VERAO = new DateTime(2017, 12, 23);
        private DateTime FIM_VERAO = new DateTime(2018, 03, 21);

        decimal GetValorTotal(DateTime data, int quantidade)
        {
            decimal total;

            if (data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO))
                total = quantidade * _taxaInverno + _taxaServicoInverno;
            else
                total = quantidade * _taxaVerao;

            return total;
        }
    }

    static class DateTimeExtensions
    {
        public static bool EhAntesDe(this DateTime estaData, DateTime aquelaData)
        {
            return DateTime.Compare(aquelaData, estaData) < 0;
        }

        public static bool EhDepoisDe(this DateTime estaData, DateTime aquelaData)
        {
            return DateTime.Compare(aquelaData, estaData) > 0;
        }
    }
}
