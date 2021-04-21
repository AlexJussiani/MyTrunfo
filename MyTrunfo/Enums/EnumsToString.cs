using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrunfo.Enums
{
    public static class EnumsToString
    {
        public static String ToString(ECategory category)
        {
            switch (category)
            {
                case ECategory.Consumption:
                    return "Consumo";
                case ECategory.Displacements:
                    return "Cilindrada";
                case ECategory.HorsePower:
                    return "Potência";
                case ECategory.Length:
                    return "Comprimento";
                case ECategory.MaxSpeed:
                    return "Velocidade Máxima";
                default:
                    return String.Empty;
            }
            
        }
    }
}
