using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R38.IntroduceNullObject.antes
{
    class Problema
    {
        readonly PlanoDeCobranca planoDeCobranca;

        public Problema()
        {
            planoDeCobranca = new PlanoDeCobranca();
        }

        void DoSomething()
        {
            Plano plano;
            Cliente cliente = null;

            if (cliente == null)
            {
                plano = planoDeCobranca.Basico();
            }
            else
            {
                plano = cliente.GetPlano();
            }
        }

    }

    public class Plano
    {

    }

    public class Cliente
    {
        public virtual bool IsNull
        {
            get { return true; }
        }

        public virtual Plano GetPlano()
        {
            throw new NotImplementedException();
        }
    }

    public class PlanoDeCobranca
    {
        public Plano Basico()
        {
            throw new NotImplementedException();
        }
    }

}
