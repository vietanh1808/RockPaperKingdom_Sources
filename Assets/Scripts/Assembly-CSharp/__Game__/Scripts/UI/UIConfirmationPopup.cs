using System;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UIConfirmationPopup : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _confirmButton;

		[SerializeField]
		private UIButtonClick _cancelButton;

		private Action _onConfirm;

		public void OpenWithConfirm(Action onConfirm)
		{
		}

		private void OnDisable()
		{
		}

		private void OnConfirmButtonClicked()
		{
		}

		private void OnCancelButtonClicked()
		{
		}
	}
}
