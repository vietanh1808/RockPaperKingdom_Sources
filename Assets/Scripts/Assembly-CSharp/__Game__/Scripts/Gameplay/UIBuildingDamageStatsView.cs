using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingDamageStatsView : MonoBehaviour
	{
		[SerializeField]
		private UIBuildingDamageStatsItem _itemPrefab;

		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private GameObject _emptyStateContainer;

		[SerializeField]
		private float _elementAppearDelay;

		private BuildingDamageTracker _buildingDamageTracker;

		[Inject]
		public void Inject(BuildingDamageTracker buildingDamageTracker)
		{
		}

		private void OnEnable()
		{
		}

		private void ClearItems()
		{
		}

		private void AnimateItem(Transform itemTransform, int index)
		{
		}
	}
}
