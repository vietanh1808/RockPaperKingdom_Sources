using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.UI
{
	public class UIButtonClick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerExitHandler
	{
		[Header("Settings")]
		[SerializeField]
		private bool _isInteractable;

		[SerializeField]
		private bool _isActionable;

		[SerializeField]
		private UnityEvent _onClick;

		[Header("Option")]
		[SerializeField]
		private UIButtonMessage _buttonMessage;

		[Header("SoundFX")]
		[SerializeField]
		private SoundData _actionSoundData;

		[SerializeField]
		private SoundData _messageSoundData;

		[Header("Animation")]
		[SerializeField]
		private RectTransform _animationTarget;

		private RectTransform _rectTransform;

		private Tween _shakeTween;

		public bool IsInteractable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsActionable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public UnityEvent OnClick => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void SetMessage(string message)
		{
		}

		private void ShowMessage()
		{
		}

		private void OnButtonClicked()
		{
		}

		private void DownScale()
		{
		}

		private void DefaultScale()
		{
		}
	}
}
