HIDE METHOD

```
class HotelFazenda
{
    private decimal _taxaInverno;
    private decimal _taxaServicoInverno;
    private decimal _taxaVerao;

    public HotelFazenda(decimal taxaInverno, decimal taxaServicoInverno, decimal taxaVerao)
    {
        _taxaInverno = taxaInverno;
        _taxaServicoInverno = taxaServicoInverno;
        _taxaVerao = taxaVerao;
    }

    private DateTime INICIO_VERAO = new DateTime(2017, 12, 23);
    private DateTime FIM_VERAO = new DateTime(2018, 03, 21);

    public decimal GetValorTotal(Periodo periodoHospedagem)
    {
        if (NaoEhVerao(periodoHospedagem.DataInicial))
            return TaxaInverno(periodoHospedagem.Dias);

        return TaxaVerao(periodoHospedagem.Dias); //early return
    }

    public decimal TaxaVerao(int dias)
    {
        return dias * _taxaVerao;
    }

    private decimal TaxaInverno(int dias)
    {
        return dias * _taxaInverno + _taxaServicoInverno;
    }

    public bool NaoEhVerao(DateTime data)
    {
        return data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO);
    }
}
```