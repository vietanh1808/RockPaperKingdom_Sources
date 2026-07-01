using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_Reroll", menuName = "TapHub/Gameplay/Reroll Config")]
	public class RerollConfig : ScriptableObject
	{
		[SerializeField]
		private InventoryItemData _freeRerollItem;

		[SerializeField]
		private InventoryItemData _rvRerollItem;

		[SerializeField]
		private InventoryItemData _freeRerollsPerkItem;

		public InventoryItemData FreeRerollItem => null;

		public InventoryItemData RvRerollItem => null;

		public InventoryItemData FreeRerollsPerkItem => null;
	}
}
