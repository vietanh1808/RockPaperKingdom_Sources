using System;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UITutorialDescription : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		private Action _onButtonClicked;

		public void Show(Action onButtonClicked)
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
