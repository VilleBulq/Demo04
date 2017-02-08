using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_5
{
    class Radio
    {

        private int MaxVol = 9;
        private float MinFreq = 2000;
        private float MaxFreq = 26000;
        private int Volume { get; set; }
        private float Freq { get; set; }
        public bool SetOn { get; set; }
      
        public void SetVol(int vol) {
        if(vol >= 1 && vol <= MaxVol) {
                SetOn = true;
                Volume = vol;
        }else {
                SetOn = false;
        }
        }
        public void SetFreq(float freq) {
        if(freq <= MaxFreq && freq >= MinFreq) {
                Freq = freq;
        }
        else {
                Freq = Freq;
        }
        }
        public override string ToString()
        {
            return base.ToString() + "Is on ? " + SetOn + " Freq " + Freq + " Volume "+Volume;
        }

    }
}