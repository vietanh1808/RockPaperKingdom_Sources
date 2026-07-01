using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UILevelUpProgressView : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TMP_Text _levelText;

		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private Transform _contentTransform;

		[Header("Animation Timing")]
		[SerializeField]
		private float _delayBeforeFill;

		[SerializeField]
		private float _fillDuration;

		[SerializeField]
		private float _popScale;

		[SerializeField]
		private float _popDuration;

		[SerializeField]
		private float _pauseBeforeRefill;

		[SerializeField]
		private float _refillDuration;

		private Sequence _sequence;

		public event Action OnComplete
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

		public event Action OnLevelChanged
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

		public void SetInitialState(int previousLevel, float previousProgress)
		{
		}

		public void Play(int previousLevel, int currentLevel, float previousProgress, float currentProgress)
		{
		}

		public void Stop()
		{
		}

		private void AppendFillToMax(Sequence sequence)
		{
		}

		private void AppendPop(Sequence sequence, int currentLevel)
		{
		}

		private void AppendRefill(Sequence sequence, float currentProgress)
		{
		}
	}
}
