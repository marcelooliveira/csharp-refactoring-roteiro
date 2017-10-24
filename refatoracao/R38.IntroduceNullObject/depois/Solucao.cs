using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R38.IntroduceNullObject.depois
{
    class Solucao
    {
        void DoSomething()
        {
            Plano plano;
            Pedido pedido = null;
            Cliente cliente = null;

            // Substituir valores NULL com objeto Null
            cliente = pedido.Cliente ?? new NullCliente();

            // Usar objeto NULL como se fosse uma subclasse qualquer
            plano = cliente.GetPlano();
        }
    }

    class Pedido
    {
        internal NullCliente Cliente;
    }

    public sealed class NullCliente : Cliente
    {
        public override bool IsNull
        {
            get { return true; }
        }

        public override Plano GetPlano()
        {
            return new NullPlano();
        }
        // Alguma outra funcionalidade para plano NULL
    }

    public class Plano
    {

    }

    public sealed class NullPlano : Plano
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
