using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_Energy", menuName = "TapHub/Configs/Energy Config")]
	public class EnergyConfig : ScriptableObject
	{
		[SerializeField]
		private EnergyItemData _energyItemData;

		[SerializeField]
		private int _maxAmount;

		[SerializeField]
		private int _sessionPrice;

		[SerializeField]
		private int[] _recoverMinutesPerStage;

		[SerializeField]
		private InventoryItemData _capacityExtensionItemData;

		public EnergyItemData EnergyItemData => null;

		public InventoryItemData CapacityExtensionItemData => null;

		public Sprite Icon => null;

		public int MaxAmount => 0;

		public int SessionPrice => 0;

		public int GetRecoverMinutes(int stageIndex)
		{
			return 0;
		}
	}
}
