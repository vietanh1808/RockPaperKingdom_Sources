using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentUpgradesView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootLayout;

		[SerializeField]
		private UIEquipmentModifierElement _modifierElementPrefab;

		private RarityConfig _rarityConfig;

		[Inject]
		public void Inject(RarityConfig rarityConfig)
		{
		}

		public void Construct(EquipmentItem item)
		{
		}
	}
}
