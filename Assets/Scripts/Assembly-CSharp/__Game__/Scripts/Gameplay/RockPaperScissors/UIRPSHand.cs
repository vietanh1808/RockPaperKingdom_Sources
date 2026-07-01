using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRPSHand : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private Image _handImage;

		[Header("Hand Sprites")]
		[SerializeField]
		private Sprite _defaultSprite;

		[SerializeField]
		private Sprite _rockSprite;

		[SerializeField]
		private Sprite _paperSprite;

		[SerializeField]
		private Sprite _scissorsSprite;

		[Header("Animation Settings")]
		[SerializeField]
		private float _animationDuration;

		[SerializeField]
		private float _positionAmplitude;

		[SerializeField]
		private float _rotationAmplitude;

		[Header("Punch Settings")]
		[SerializeField]
		private float _punchScaleAmount;

		[SerializeField]
		private float _punchRotationAmount;

		[SerializeField]
		private float _punchDuration;

		[Header("Audio")]
		[SerializeField]
		private SoundBundleData _swooshSfx;

		private Vector2 _initialPosition;

		private Vector3 _initialRotation;

		private Tween _positionTween;

		private Tween _rotationTween;

		private Tween _punchScaleTween;

		private Tween _punchRotationTween;

		private bool _isInitialized;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetChoiceSprite(RPSChoice choice)
		{
		}

		public void ResetToDefault()
		{
		}

		public void StartAnimation()
		{
		}

		public void PlayPunchAnimation()
		{
		}

		public void ResetAnimation()
		{
		}

		private void KillAllTweens()
		{
		}

		private void RestoreInitialState()
		{
		}

		private Sprite GetSprite(RPSChoice choice)
		{
			return null;
		}

		private void CaptureInitialState()
		{
		}
	}
}
