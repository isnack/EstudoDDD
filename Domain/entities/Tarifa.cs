using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Tarifa
    {
        public string origem { get; private set; }
        public string destino { get; private set; }
        public double valor { get; private set; }

        public Tarifa(string origem,string destino,double valor)
        {
            this.origem = origem;
            this.destino = destino;
            this.valor = valor;
        }

        public double ValorMinutoComMulta()
        {
            if (valor <= 0) return 0;
            double valorMulta = valor +( valor * 0.10);
            return valorMulta;
        }
        public double valorTotal(int minutos)
        {
            if (valor <= 0 || minutos <=0) return 0;
            return minutos * valor;
        }

        public double valorTotalComMulta(int minutos)
        {
            if (valor <= 0 || minutos <= 0) return 0;

            return minutos* ValorMinutoComMulta();
        }
    }
}
