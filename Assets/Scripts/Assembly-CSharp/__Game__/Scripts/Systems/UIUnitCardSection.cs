using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardSection : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _cardsContainer;

		[SerializeField]
		private UIUnitCardInventoryElement _elementPrefab;

		private UnitCardSystem _unitCardSystem;

		private RarityConfig _rarityConfig;

		private DiContainer _diContainer;

		private UIMenuSceneNavigation _menuSceneNavigation;

		private readonly List<UIUnitCardInventoryElement> _elements;

		public IReadOnlyList<UIUnitCardInventoryElement> Elements => null;

		[Inject]
		private void Inject(UnitCardSystem unitCardSystem, RarityConfig rarityConfig, DiContainer diContainer, UIMenuSceneNavigation menuSceneNavigation)
		{
		}

		public void SetHero(HeroItem hero)
		{
		}

		public void ClearElements()
		{
		}

		private void OnElementButtonClicked(UnitCardItem unitCardItem)
		{
		}
	}
}
