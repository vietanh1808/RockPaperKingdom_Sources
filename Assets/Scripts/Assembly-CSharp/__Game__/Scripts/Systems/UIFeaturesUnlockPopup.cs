using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIFeaturesUnlockPopup : UIBasePopup
	{
		[SerializeField]
		private Image _featureIcon;

		[SerializeField]
		private TMP_Text _featureTitle;

		[Header("Animation References")]
		[SerializeField]
		private RectTransform _frameContainer;

		[SerializeField]
		private CanvasGroup _frameCanvasGroup;

		[SerializeField]
		private RectTransform _contentContainer;

		[SerializeField]
		private CanvasGroup _contentCanvasGroup;

		[SerializeField]
		private RectTransform _iconContainer;

		[SerializeField]
		private Image _backgroundImage;

		[Header("Sound FX")]
		[SerializeField]
		private SoundData _popupAppearSfx;

		[SerializeField]
		private SoundData _iconAppearSfx;

		[SerializeField]
		private SoundData _iconMoveSfx;

		[Header("Frame Appear")]
		[SerializeField]
		private float _frameScaleFrom;

		[SerializeField]
		private float _frameScaleDuration;

		[Header("Content Appear")]
		[SerializeField]
		private float _contentAppearDelay;

		[SerializeField]
		private float _contentScaleFrom;

		[SerializeField]
		private float _contentScaleDuration;

		[SerializeField]
		private float _contentFadeDuration;

		[SerializeField]
		private float _contentDisplayDuration;

		[Header("Fade Out & Move")]
		[SerializeField]
		private float _fadeOutDuration;

		[SerializeField]
		private float _moveDuration;

		[SerializeField]
		private float _moveScaleEnd;

		[SerializeField]
		private float _noTargetDisplayDuration;

		[Header("Target Pop")]
		[SerializeField]
		private float _targetPopScale;

		[SerializeField]
		private float _targetPopDuration;

		private const float MAX_BACKGROUND_ALPHA = 0.98f;

		private FeatureUnlockSystem _featureUnlockSystem;

		private UIFeatureUnlockTargetRegistry _targetRegistry;

		private FeatureItem _featureItem;

		private Sequence _animationSequence;

		private Vector3 _iconInitialLocalPosition;

		private Vector3 _iconInitialLocalScale;

		[Inject]
		private void Inject(FeatureUnlockSystem featureUnlockSystem, UIFeatureUnlockTargetRegistry targetRegistry)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void SetFeature(FeatureItem featureItem)
		{
		}

		private void PlayAnimation()
		{
		}

		private void AppendFlyToTargetAnimation(float fadeOutStart, RectTransform targetTransform)
		{
		}

		private void ResetAnimationState()
		{
		}

		private void KillAnimation()
		{
		}
	}
}
