using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class UIWaveAlertMessage : MonoBehaviour
	{
		private const float MESSAGE_DISPLAY_DURATION = 2f;

		[SerializeField]
		private GameObject _rootContainer;

		[SerializeField]
		private Image _alertIcon;

		[SerializeField]
		private TMP_Text _messageText;

		private Tween _currentDelayedCall;

		public void ShowAlert(AlertData alertData)
		{
		}

		private void HideMessage()
		{
		}
	}
}
