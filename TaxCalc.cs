using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp
{
    public class TaxCalc
    {
        public float Betrag { get; set; }

        public float BetragBrutto { get; set; }

        public float BetragNetto { get; set; }

        public float BetragUst { get; set; }

        public bool IsNetto { get; set; }

        public float UstProzent { get; set; }

        public void CalcResult()
        {
            if (IsNetto)
            {
                BetragUst = Betrag * UstProzent;
                BetragNetto = Betrag;
                BetragBrutto = Betrag + BetragUst;
            }
            else
            {
                BetragUst = Betrag - (Betrag / (1 + UstProzent));
                BetragBrutto = Betrag;
                BetragNetto = Betrag - BetragUst;
            }
        }
    }
}
