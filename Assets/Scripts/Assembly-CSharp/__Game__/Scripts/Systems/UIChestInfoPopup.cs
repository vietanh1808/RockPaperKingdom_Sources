using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIChestInfoPopup : UIBasePopup
	{
		[SerializeField]
		private RectTransform _scrollContainer;

		[SerializeField]
		private UIChestContentView _uiChestContentPrefab;

		private readonly List<UIChestContentView> _chestContentViews;

		private ChestData _chestData;

		private UIChestContentFactory _uiChestContentFactory;

		[Inject]
		private void Inject(UIChestContentFactory uiChestContentFactory)
		{
		}

		public void SetChest(ChestData chestData)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void AddView(RarityProbabilityItem rarityProbability)
		{
		}

		private void RemoveView(UIChestContentView itemsView)
		{
		}
	}
}
