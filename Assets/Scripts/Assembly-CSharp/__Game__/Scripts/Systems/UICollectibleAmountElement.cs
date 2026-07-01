using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleAmountElement : MonoBehaviour
	{
		private const string MAX_LEVEL_TEXT = "max.";

		[SerializeField]
		private Slider _amountSlider;

		[SerializeField]
		private TMP_Text _amountText;

		public void RefreshAmount(int currentAmount, int requiredAmount)
		{
		}

		public void SetMaxLevel()
		{
		}
	}
}
