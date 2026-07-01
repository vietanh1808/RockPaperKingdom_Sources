using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleRewardButton : MonoBehaviour
	{
		[Header("Button")]
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _rewardIcon;

		[SerializeField]
		private TMP_Text _amountText;

		[Header("Floating Reward")]
		[SerializeField]
		private CanvasGroup _floatingContainer;

		[SerializeField]
		private RectTransform _floatingRectTransform;

		[SerializeField]
		private Image _floatingIcon;

		[SerializeField]
		private TMP_Text _floatingText;

		[Header("Animation")]
		[SerializeField]
		private float _floatDistance;

		[SerializeField]
		private float _floatDuration;

		[SerializeField]
		private float _fadeOutDuration;

		private Reward _reward;

		private Action _onClaimed;

		private Sequence _animationSequence;

		public void Construct(Reward reward, Action onClaimed)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnClaimClicked()
		{
		}

		private void PlayFloatingAnimation()
		{
		}

		private void KillAnimation()
		{
		}
	}
}
