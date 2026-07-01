using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UIButtonClickSwitch : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private GameObject _turnOnChild;

		[SerializeField]
		private GameObject _turnOffChild;

		private bool _isOn;

		public bool IsOn => false;

		public event Action<bool> OnSwitchStateChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetState(bool isOn)
		{
		}

		private void OnButtonClicked()
		{
		}

		private void UpdateVisuals()
		{
		}
	}
}
