using System;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace __Game__.Scripts.UI
{
	public abstract class UIBasePopup : SerializedMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private Image _closeOnBackgroundClick;

		private Action _onClosed;

		public event Action OnPopupEnabled
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

		public event Action OnPopupDisabled
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

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OpenPopup(Action onClosed = null)
		{
		}

		protected virtual void ClosePopup()
		{
		}
	}
}
