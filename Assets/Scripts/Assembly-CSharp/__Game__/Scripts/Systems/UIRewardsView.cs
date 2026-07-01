using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class UIRewardsView : MonoBehaviour
	{
		private const float ELEMENT_ANIMATION_DURATION = 0.35f;

		[Header("Animation")]
		[SerializeField]
		private bool _appearAnimated;

		[SerializeField]
		private float _elementAppearDelay;

		[SerializeField]
		private float _initialDelay;

		[Header("Audio")]
		[SerializeField]
		private SoundData _appearSound;

		private UIRewardsFactory _uiRewardsFactory;

		public event Action OnAnimationComplete
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
		public void Inject(UIRewardsFactory uiRewardsFactory)
		{
		}

		public void Construct(List<Reward> rewards)
		{
		}

		private void AppearAnimated(GameObject element, int index, bool isLast)
		{
		}

		public void ApplyDoubleReward()
		{
		}

		private void PlaySfx()
		{
		}
	}
}
