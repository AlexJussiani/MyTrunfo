using MyTrunfo.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrunfo.Enums
{
    public static class EnumsImageCountry
    {
        public static Image ImageCoutry(ECountry country)
        {
            switch(country)
            {
                case ECountry.France :
                    return Resources.France;
                case ECountry.Germany:
                    return Resources.Germany;
                case ECountry.Italy:
                    return Resources.Italy;
                case ECountry.Japan:
                    return Resources.Japan;
                case ECountry.SouthCorea:
                    return Resources.SouthCorea;
                case ECountry.USA:
                    return Resources.USA;
                default:
                    return null;
            }
        }
    }
}
