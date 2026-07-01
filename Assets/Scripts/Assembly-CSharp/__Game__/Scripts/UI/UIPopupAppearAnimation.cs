using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.UI
{
	public class UIPopupAppearAnimation : MonoBehaviour
	{
		[SerializeField]
		private Image _background;

		[SerializeField]
		private Transform _frame;

		[SerializeField]
		private SoundData _appearSound;

		private void OnEnable()
		{
		}
	}
}
