using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems.Offers.UI
{
	public class UIOfferRewardItem : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private TMP_Text _description;

		[SerializeField]
		private TMP_Text _amount;

		private UIItemMessage _uiItemMessage;

		private Reward _reward;

		[Inject]
		private void Inject(UIItemMessage uiItemMessage)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Setup(Reward reward)
		{
		}

		private void ShowMessage()
		{
		}
	}
}
