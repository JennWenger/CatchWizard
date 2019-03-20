using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchWizardException
{
    class Wizard
    {
        private DateTime lastMagicEvent = DateTime.MinValue;
        private const double MinimumMannaRechargeTime = 5.0;
        private const double AdvancedMagicMannaRechargeTime = 9.75;
        private const string RegularMagicWord = "Hokus pokus.";
        private const string AdvancedMagicWord = "Alakazam";

        public void DoMagic()
        {
            TimeSpan dt = DateTime.Now - lastMagicEvent;
            if (dt.TotalSeconds < MinimumMannaRechargeTime)
                throw new OutOfMannaException(
                    string.Format(
                        "Please wait at least {0} seconds.",
                        MinimumMannaRechargeTime - dt.TotalSeconds
                    )
                );

            if (dt.TotalSeconds < AdvancedMagicMannaRechargeTime)
                Console.WriteLine(RegularMagicWord);
            else
                Console.WriteLine(AdvancedMagicWord);
            lastMagicEvent = DateTime.Now;
        }
    }
}
