using Zenject;

namespace __Game__.Scripts.Systems
{
	public class PurchaseProviderFactory
	{
		private readonly DiContainer _container;

		public PurchaseProviderFactory(DiContainer container)
		{
		}

		public BasePurchaseProvider Create(PurchaseData purchaseData)
		{
			return null;
		}
	}
}
