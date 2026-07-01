using System;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class PurchaseAlertSystem : IInitializable, IDisposable
	{
		private readonly PurchaseAlertCollection _purchaseAlertCollection;

		private readonly PurchaseSystem _purchaseSystem;

		private int _purchaseCount;

		private bool _alertPurchase;

		public bool AlertPurchase
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnAlertPurchaseChanged
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

		public PurchaseAlertSystem(PurchaseAlertCollection purchaseAlertCollection, PurchaseSystem purchaseSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnAlertPurchaseChangedHandler(bool alertUpgrade)
		{
		}
	}
}
