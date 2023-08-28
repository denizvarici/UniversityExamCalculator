using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business.Concrete
{
    public class ExamManager
    {
        public float FinaldenKacAlmaliyim(float gecmePuani,float vizePuani,int vizeOrani)
        {
            float vizeEtkisi = (vizePuani * vizeOrani) / 100;
            float gecmeEksiVizeEtkisi = gecmePuani - (vizeEtkisi);
            return (gecmeEksiVizeEtkisi * 100) / (100 - vizeOrani);
        }
    }
}
