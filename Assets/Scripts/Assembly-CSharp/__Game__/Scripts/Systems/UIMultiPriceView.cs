using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIMultiPriceView : MonoBehaviour
	{
		[SerializeField]
		private UIPriceView _priceViewPrefab;

		private InventorySystem _inventorySystem;

		[Inject]
		public void Inject(InventorySystem inventorySystem)
		{
		}

		public void Construct(List<PriceData> price)
		{
		}
	}
}
