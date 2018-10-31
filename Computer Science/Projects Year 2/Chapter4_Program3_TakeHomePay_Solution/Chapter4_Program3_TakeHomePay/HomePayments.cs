using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Program3_TakeHomePay
{
    class HomePayments
    {
        private const double RETIREMENT = 0.1, FEDERAL = 0.18, SOCIAL_SECURITY = 0.06;
        public HomePayments(string x, double y, double z)
        {
            double newPay = z * (FEDERAL + RETIREMENT + SOCIAL_SECURITY);
            Console.WriteLine($"{x} will take home a total of {newPay:C2} from {y:C2}");
        }
    }
}
