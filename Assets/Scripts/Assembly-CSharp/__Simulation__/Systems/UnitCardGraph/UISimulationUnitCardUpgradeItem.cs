using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.UnitCardGraph
{
	public class UISimulationUnitCardUpgradeItem : MonoBehaviour
	{
		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _itemImage;

		[SerializeField]
		private TMP_Text _levelValue;

		[Header("Rarity Settings")]
		[SerializeField]
		private Sprite _commonCard;

		[SerializeField]
		private Sprite _rareCard;

		[SerializeField]
		private Sprite _epicCard;

		public void Construct(UnitCardItem unitCardItem)
		{
		}

		private Sprite GetCardSprite(RarityType rarityType)
		{
			return null;
		}
	}
}
