using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "Config_Debugger", menuName = "TapHub/Configs/Debugger")]
	public class DebuggerConfig : ScriptableObject
	{
		[Header("Progress")]
		[SerializeField]
		private bool _isFeatureUnlocked;

		[SerializeField]
		private bool _isTutorialIgnore;

		[Header("Items")]
		[SerializeField]
		private InventoryItemData _moneyItemData;

		[SerializeField]
		private InventoryItemData _gemItemData;

		[SerializeField]
		private List<InventoryItemData> _keys;

		[SerializeField]
		private List<InventoryItemData> _allInventoryItems;

		[SerializeField]
		private InventoryItemData _darkStarItemData;

		[Header("Chests")]
		[SerializeField]
		private List<ChestData> _chests;

		[Header("Materials")]
		[SerializeField]
		private string _materialsFolderPath;

		[SerializeField]
		private string _materialsNamePrefix;

		[SerializeField]
		private List<InventoryItemData> _materials;

		public InventoryItemData MoneyItemData => null;

		public InventoryItemData GemItemData => null;

		public InventoryItemData DarkStarItemData => null;

		public List<InventoryItemData> Keys => null;

		public List<InventoryItemData> AllInventoryItems => null;

		public List<ChestData> Chests => null;

		public List<InventoryItemData> Materials => null;

		public bool IsFeatureUnlocked => false;

		public bool IsTutorialIgnore => false;
	}
}
