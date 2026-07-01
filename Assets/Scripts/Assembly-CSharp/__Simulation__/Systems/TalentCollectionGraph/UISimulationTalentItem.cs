using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.TalentCollectionGraph
{
	public class UISimulationTalentItem : MonoBehaviour
	{
		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _levelText;

		[Header("Rarity Settings")]
		[SerializeField]
		private Sprite _commonCard;

		[SerializeField]
		private Sprite _rareCard;

		[SerializeField]
		private Sprite _epicCard;

		public void Construct(TalentItemSnapshot talentSnapshot)
		{
		}

		private Sprite GetCardSprite(RarityType rarityType)
		{
			return null;
		}
	}
}
