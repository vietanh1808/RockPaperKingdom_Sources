using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "InventoryItemData", menuName = "TapHub/Inventory/Inventory Item Data")]
	public class InventoryItemData : SerializedScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private string _title;

		[Multiline]
		[SerializeField]
		private string _description;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private Sprite _background;

		[Header("Lion Analytics")]
		[SerializeField]
		private bool _ignoreLionAnalytics;

		[SerializeField]
		private LionAnalyticsProductType _lionAnalyticsProductType;

		[SerializeField]
		private string _lionAnalyticsType;

		[SerializeField]
		private string _lionAnalyticsTitle;

		public string Guid => null;

		public string Title => null;

		public string Description => null;

		public Sprite Icon => null;

		public Sprite Background => null;

		public bool IgnoreLionAnalytics => false;

		public LionAnalyticsProductType LionAnalyticsProductType => default(LionAnalyticsProductType);

		public string LionAnalyticsType => null;

		public string LionAnalyticsTitle => null;
	}
}
