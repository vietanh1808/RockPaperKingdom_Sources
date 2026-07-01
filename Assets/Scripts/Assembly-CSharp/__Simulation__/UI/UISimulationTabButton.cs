using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Simulation__.UI
{
	public class UISimulationTabButton : MonoBehaviour
	{
		[SerializeField]
		private GameObject _contentContainer;

		[Header("View")]
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _background;

		[Header("Settings")]
		[SerializeField]
		private Color _focusColor;

		[SerializeField]
		private Color _closedColor;

		public event Action<UISimulationTabButton> OnActivated
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

		private void Start()
		{
		}

		public void Deactivate()
		{
		}

		public void Activate()
		{
		}
	}
}
