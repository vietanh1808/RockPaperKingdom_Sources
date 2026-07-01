using System;
using UnityEngine;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRestoreGameplayProgressPopup : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _continueButton;

		[SerializeField]
		private UIButtonClick _quitButton;

		private Action _onContinue;

		private Action _onQuit;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open(Action onCompleteHandler, Action onQuitHandler)
		{
		}

		private void OnContinueButtonHandler()
		{
		}

		private void OnQuitButtonHandler()
		{
		}
	}
}
