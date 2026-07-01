using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Collection_Purchase", menuName = "TapHub/Shop/Purchase/Purchase Collection")]
	public class PurchaseCollection : ScriptableObject
	{
		[SerializeField]
		private string _folderPath;

		[SerializeField]
		private List<PurchaseData> _items;

		public List<PurchaseData> Items => null;
	}
}
