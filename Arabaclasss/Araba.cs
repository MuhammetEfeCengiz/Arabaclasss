using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabaclasss
{
    class Araba
    {
        private string marka;
        public string model;
        private string plaka;
        public int yil;
        public int hiz;

        public Araba()
        {
            hiz = 0;
        }
        public int hizartti()
        {
            hiz = hiz + 50;
            return hiz;

        }
        public int hizazalt()
        {
            hiz = hiz - 25;
            return hiz;

        }
        public string Plaka
        {
            get { return plaka; }
            set
            {
                if (value.Length >= 5)
                {
                    plaka = value;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("lutfen Tekrar girin");
                }

            }

        }
        public string marka
        {
            get { return marka; }
            set
            {
                if (true)
                {
                    plaka = value;
                }

            }
        } 
           



    }
}
