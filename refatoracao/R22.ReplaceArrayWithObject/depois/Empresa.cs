using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R22.ReplaceArrayWithObject.depois
{
    class Empresa
    {
        public Empresa()
        {
            Filial filial = new Filial("Curitiba");
            filial.SetPontos(15);
        }
    }

    class Filial
    {
        private string nome;
        private int pontos;

        public Filial(string nome)
        {
            this.nome = nome;
        }

        public void SetPontos(int pontos)
        {
            this.pontos = pontos;
        }
    }
}
