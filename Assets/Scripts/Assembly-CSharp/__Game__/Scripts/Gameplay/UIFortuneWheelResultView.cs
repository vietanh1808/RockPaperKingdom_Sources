using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UIFortuneWheelResultView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _selectedContainer;

		[SerializeField]
		private UIFortuneWheelResultElement _uiFortuneWheelResultPrefab;

		[SerializeField]
		private Transform _tapToContinue;

		private const float ElementAppearDelay = 0.35f;

		public void Construct(List<FortuneWheelItem> selectedItems)
		{
		}
	}
}
