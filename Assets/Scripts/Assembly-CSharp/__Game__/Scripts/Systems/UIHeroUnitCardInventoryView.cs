using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIHeroUnitCardInventoryView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIUnitCardInventoryElement _elementPrefab;

		private UnitCardSystem _unitCardSystem;

		private RarityConfig _rarityConfig;

		private DiContainer _diContainer;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private readonly List<UIUnitCardInventoryElement> _elements;

		[Inject]
		private void Inject(UnitCardSystem unitCardSystem, RarityConfig rarityConfig, DiContainer diContainer, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		public void SetHeroItem(HeroItem hero)
		{
		}

		private void OnDisable()
		{
		}

		private void ClearElements()
		{
		}

		private void OnElementButtonClicked(UnitCardItem unitCardItem)
		{
		}
	}
}
