using LeTai.TrueShadow;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIUnlockedUnitCardElement : MonoBehaviour
	{
		[Header("Default")]
		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _titleText;

		[Header("Rarity")]
		[SerializeField]
		private TrueShadow _outlineShadow;

		private RarityConfig _rarityConfig;

		[Inject]
		private void Inject(RarityConfig rarityConfig)
		{
		}

		public void SetData(UnitCardItemData cardData)
		{
		}

		public void Hide()
		{
		}

		private void SetupOutlineColor(UnitCardItemData cardData)
		{
		}
	}
}
