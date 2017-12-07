Como refatorar?

```<language>
public double GetVelocidade()
{
    switch (tipo)
    {
        case R2D2:
            return GetVelocidadePadrao();
        case WALLY:
            return GetVelocidadePadrao() - GetCapacidadeDeCarga() * numeroDeBlocos;
        case BAYMAX:
            return comArmadura ? 0 : GetVelocidadePadrao(potencia);
        default:
            throw new Exception("Tipo não identificado");
    }
}
```