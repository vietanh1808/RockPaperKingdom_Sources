using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_PurchaseAlerts", menuName = "TapHub/Shop/Purchase Alerts Collection")]
	public class PurchaseAlertCollection : ScriptableObject
	{
		[SerializeField]
		private List<PurchaseData> _items;

		public List<PurchaseData> Items => null;
	}
}
