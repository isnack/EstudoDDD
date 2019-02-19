using System;
using System.Collections.Generic;
using System.Text;

namespace Domain

{
    public class Plano :IPlano
    {
        protected  int minutosPlano;
        public int calcularDescontoMinutosPlano(int minutos)
        {
            if (EstaDentroDoPlano(minutos)) return 0;
            int result = minutos - minutosPlano;
            return result;
        }

        public bool EstaDentroDoPlano(int minutos)
        {
            int result = minutos - minutosPlano;
            return result <= 0 ? true : false;
        }
    }
}
