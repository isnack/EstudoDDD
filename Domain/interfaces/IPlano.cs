using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IPlano
    {
         bool EstaDentroDoPlano(int minutos);
         int calculateDiscountPlanMinutes(int minutos);
    }
}
