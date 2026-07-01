using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIChestResultView : MonoBehaviour
	{
		[SerializeField]
		private float _appearDelay;

		[SerializeField]
		private float _initialDelay;

		[Header("Layout")]
		[SerializeField]
		private GridLayoutGroup _gridLayoutGroup;

		[SerializeField]
		private RectTransform _gridRectTransform;

		[SerializeField]
		private ContentSizeFitter _contentSizeFitter;

		private readonly List<UIUnitCardRewardElement> _resultElements;

		private UIRewardsFactory _uiRewardsFactory;

		[Inject]
		public void Inject(UIRewardsFactory uiRewardsFactory)
		{
		}

		public void Construct(List<ChestRewardDisplayItem> displayItems, Action onAllShown = null)
		{
		}

		private void CreateElements(List<ChestRewardDisplayItem> displayItems, Action onAllShown)
		{
		}

		private void RefreshLayoutMode(int elementCount)
		{
		}

		private float CalculateContentHeight(int elementCount)
		{
			return 0f;
		}

		private void EnableGrowMode()
		{
		}

		private void EnableCenterMode()
		{
		}

		private void RemoveAllElements()
		{
		}

		private void AddElement(ChestRewardDisplayItem displayItem, int index, Action onShown)
		{
		}
	}
}
