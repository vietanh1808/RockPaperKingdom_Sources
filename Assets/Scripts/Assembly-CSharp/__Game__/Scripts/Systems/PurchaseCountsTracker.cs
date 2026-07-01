using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class PurchaseCountsTracker
	{
		private Dictionary<string, int> _purchaseCounts;

		public IReadOnlyDictionary<string, int> PurchaseCounts => null;

		public event Action<PurchaseData> OnPurchaseRegistered
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void LoadData(Dictionary<string, int> purchaseCounts)
		{
		}

		public int GetPurchaseCount(PurchaseData purchaseData)
		{
			return 0;
		}

		public void RegisterPurchase(PurchaseData purchaseData)
		{
		}
	}
}
