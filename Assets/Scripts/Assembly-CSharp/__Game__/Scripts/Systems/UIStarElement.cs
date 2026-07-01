using UnityEngine;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStarElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _button;

		[SerializeField]
		private int _starIndex;

		[SerializeField]
		private GameObject _filledStar;

		[SerializeField]
		private GameObject _emptyStar;

		private UIAppReviewPopup _popup;

		public void Construct(UIAppReviewPopup popup)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetFilled(bool isFilled)
		{
		}

		private void OnStarClicked()
		{
		}
	}
}
