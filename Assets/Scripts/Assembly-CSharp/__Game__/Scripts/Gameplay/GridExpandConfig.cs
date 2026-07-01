using UnityEngine;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_GridExpand", menuName = "TapHub/Configs/Grid Expand Config")]
	public class GridExpandConfig : ScriptableObject
	{
		[SerializeField]
		private InventoryItemData _expandItemData;

		[SerializeField]
		private SoundData _expandSfx;

		public InventoryItemData ExpandItemData => null;

		public SoundData ExpandSfx => null;
	}
}
