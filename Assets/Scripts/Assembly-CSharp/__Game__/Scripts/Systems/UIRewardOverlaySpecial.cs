using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRewardOverlaySpecial : MonoBehaviour
	{
		[Header("UI")]
		[SerializeField]
		private RectTransform _congratulationsText;

		[SerializeField]
		private GameObject _confettiContainer;

		[SerializeField]
		private UIButtonClick _closeButton;

		[Header("Rewards")]
		[SerializeField]
		private UISpecialRewardElement _rewardElementPrefab;

		[SerializeField]
		private List<SpecialRewardLayoutEntry> _layoutEntries;

		[Header("Animation Timing")]
		[SerializeField]
		private float _congratulationsDelay;

		[SerializeField]
		private float _congratulationsDuration;

		[SerializeField]
		private float _confettiDelay;

		[SerializeField]
		private float _rewardsStartDelay;

		[SerializeField]
		private float _rewardAppearDuration;

		[SerializeField]
		private float _rewardAppearInterval;

		[Header("Sound FX")]
		[SerializeField]
		private SoundData _congratulationsSfx;

		[SerializeField]
		private SoundData _confettiSfx;

		[SerializeField]
		private SoundData _rewardAppearSfx;

		private Sequence _appearSequence;

		private readonly List<GameObject> _spawnedElements;

		private DiContainer _diContainer;

		private Action _onClaimPressed;

		public event Action OnRewardClaimed
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

		[Inject]
		public void Inject(DiContainer diContainer)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowRewards(List<Reward> rewards, Action onClaimPressed)
		{
		}

		private void PlayAppearAnimation(List<Reward> rewards)
		{
		}

		private void SpawnAndAnimateRewards(List<Reward> rewards)
		{
		}

		private void Close()
		{
		}

		private void ResetAnimationState()
		{
		}
	}
}
