using DG.Tweening;
using TMPro;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UIButtonMessage : MonoBehaviour
	{
		private const string DEFAULT_MESSAGE = "Not enough resources";

		[SerializeField]
		private string _message;

		[SerializeField]
		private TMP_Text _messageValue;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		private Tween _scaleTween;

		private Tween _fadeTween;

		public void SetMessage(string message)
		{
		}

		public void ShowMessage()
		{
		}

		private void ResetMessage()
		{
		}

		private void StartMessage()
		{
		}

		private void FadeMessage()
		{
		}

		private void HideMessage()
		{
		}
	}
}
