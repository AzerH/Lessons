using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13iyun
{
    public class Cars
    {
        public string marka;
        public string model;
        public int istehsal_ili;
        public int Km;
        public string suretQutusu;
        public double alisQiy;
        public double satisQiy;
        public double maxEndirim;
        private double qiymet;

        public Cars(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
        }
        public Cars(string marka, string model, int istehsal_ili)
        {
            this.marka = marka;
            this.model = model;
            this.istehsal_ili = istehsal_ili;
        }
        public Cars(string marka, string model, int istehsal_ili,int Km)
        {
            this.marka = marka;
            this.model = model;
            this.istehsal_ili = istehsal_ili;
            this.Km= Km;    
        }
        public Cars(string marka, string model, int istehsal_ili, int Km, string suretQutusu, double alisQiy, double satisQiy, double maxEndirim, double qiymet)
        {
            this.marka = marka;
            this.model = model;
            this.istehsal_ili = istehsal_ili;
            this.Km = Km;
            this.suretQutusu= suretQutusu;
            this.alisQiy = alisQiy;
            this.satisQiy = satisQiy;
            this.maxEndirim = maxEndirim;
            this.qiymet = qiymet;
        }
        public double showPrice() 
            {
            return qiymet;
            } 




    }
}
