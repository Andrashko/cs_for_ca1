using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    /*
     * ЕОМ: марка процесора, 
     * тактова частота, 
     * об’єм оперативної пам’яті, 
     * об’єм вінчестера, 
     * марка відео карти, 
     * ціна.
      */
    class PC
    {
        
        public string Processor { get; set; }
        private double _Frequency;
        public double Frequency {
            get
            {
                return _Frequency;
            }
            set
            {
                if (value >= 0)
                    _Frequency = value;
                else
                    throw new Exception("Частота не може бути відємною");
            } 
        }

        private double _RamVolume;
        public double RamVolume
        {
            get
            {
                return _RamVolume;
            }
            set
            {
                if (value >= 0)
                    _RamVolume = value;
                else
                    throw new Exception("Об'єм памяті не може бути відємним");
            }
        }

        private double _HddVolume;
        public double HddVolume
        {
            get
            {
                return _HddVolume;
            }
            set
            {
                if (value >= 0)
                    _HddVolume = value;
                else
                    throw new Exception("Об'єм памяті не може бути відємним");
            }
        }

        public string Videocard { get; set; }

        private double _Price;
        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value >= 0)
                    _Price = value;
                else
                    throw new Exception("Ціна не може бути відємною");
            }
        }

        public PC(string Processor, double Frequency, double RamVolume, double HddVolume, string Videocard, double Price )
        {
            this.Processor = Processor;
            this.Frequency = Frequency;
            this.RamVolume = RamVolume;
            this.HddVolume = HddVolume;
            this.Videocard = Videocard;
            this.Price = Price;
        }

    }
}
