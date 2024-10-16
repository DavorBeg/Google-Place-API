using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain.Google
{
	public class PaymentOptions
	{
		public bool? CreditCard { get; set; }
		public bool? DebitCard { get; set; }
		public bool? MobilePayment { get; set; }
	}
}
