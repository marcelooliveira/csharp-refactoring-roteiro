Você está trabalhando numa aplicação de relacionamento com o cliente.

Uma das funcionalidades da aplicação é verificar se o cliente
possui perfil de bom comprador e conceder um cartão premium.

A aplicação está funcionando corretamente. Durante da revisão de código,
você observa o código dos métodos `VerificarNotasFiscais` e `ObterNFPremiumEEnviarEmail`
da classe `Cliente`:

```
public void VerificarNotasFiscais(IList<NotaFiscal> notasFiscais)
{
    NotaFiscal nf = ObterNFPremiumEEnviarEmail(notasFiscais);
    if (nf != null)
    {
        CriarCartaoPremium(nf);
    }
}
        
public NotaFiscal ObterNFPremiumEEnviarEmail(IList<NotaFiscal> notasFiscais)
{
    foreach (var nf in notasFiscais)
    {
        if (nf.Valor > 10000)
        {
            EnviarEmailParabens(nf);
            return nf;
        }
    }
    return null;
}
```

Você então descobre que o método `ObterNFPremiumEEnviarEmail` assume duas responsabilidades:
ele tanto obtém a compra acima de 10 mil reais do cliente, como também faz o envio do e-mail de notificação.
Você decide utilizar o conceito chamado _Command and Query Responsibility Segregation_ (CQRS,
ou Separação de Responsabilidade entre Comando e Consulta). Para isso, você quer aplicar
a técnica de refatoração **Separar Consulta do Modificador**.

Implemente os passos necessários para realizar essa refatoração.

## Resposta

1- Notamos o "número mágico" `10000` no meio do código, logo vamos implementar
a técnica **Substituir Nùmero Mágico por Constante**:

```
private const int VALOR_NF_CLIENTE_PREMIUM = 10000;
```

2- O método `ObterNFPremiumEEnviarEmail` atuamente tem 2 responsabilidades. Vamos
pegar uma dessas responsabilidades e criar um novo método, 
que obtém a nota fiscal mas não envia o e-mail:

```
public NotaFiscal ObterNFPremium(IList<NotaFiscal> notasFiscais)
{
 	foreach (var nf in notasFiscais)
 	{
 		if (nf.Valor > VALOR_NF_CLIENTE_PREMIUM)
 		{
 		    return nf;
 		}
 	}
 	return null;
}
```

3- Já existe um método para envio do e-mail (método `EnviarEmailParabens`).
Então vamos somente modificar o corpo do método `VerificarNotasFiscais` para gerar o cliente premium se necessário:

```
public void VerificarNotasFiscais(IList<NotaFiscal> notasFiscais)
{
    NotaFiscal nf = ObterNFPremium(notasFiscais);
    if (nf != null)
    {
        EnviarEmailParabens(nf);
        CriarCartaoPremium(nf);
    }
}
```

