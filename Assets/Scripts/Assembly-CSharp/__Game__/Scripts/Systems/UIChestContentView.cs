using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIChestContentView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIHeroElement _uiHeroPrefab;

		[Header("Info")]
		[SerializeField]
		private Image _rarityImage;

		[SerializeField]
		private TMP_Text _rarityValue;

		[SerializeField]
		private TMP_Text _infoValue;

		private readonly List<UIHeroElement> _uiElements;

		private RarityProbabilityItem _rarityProbability;

		private HeroSystem _heroSystem;

		private HeroConfig _heroConfig;

		private RarityConfig _rarityConfig;

		private UIProjectHolder _uiProjectHolder;

		[Inject]
		private void Inject(HeroSystem heroSystem, HeroConfig heroConfig, RarityConfig rarityConfig, UIProjectHolder uiProjectHolder)
		{
		}

		public void Construct(RarityProbabilityItem rarityProbabilityItem)
		{
		}

		private void OnDestroy()
		{
		}

		private void SetupView()
		{
		}

		private void CreateAllElements()
		{
		}

		private void RemoveAllElements()
		{
		}

		private void AddElement(HeroItem heroItem)
		{
		}

		private void RemoveElement(UIHeroElement uiElement)
		{
		}

		private void ElementButtonClicked(HeroItem heroItem)
		{
		}
	}
}
