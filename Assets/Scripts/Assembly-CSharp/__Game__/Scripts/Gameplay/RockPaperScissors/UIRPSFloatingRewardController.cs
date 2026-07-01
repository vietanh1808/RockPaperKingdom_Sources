using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class UIRPSFloatingRewardController : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _floatingIconTemplate;

		[SerializeField]
		private RectTransform _floatingIconsContainer;

		[Header("Animation Settings")]
		[SerializeField]
		private float _floatDuration;

		[SerializeField]
		private float _peakScale;

		[SerializeField]
		private float _itemEndScale;

		[SerializeField]
		private float _currencyEndScale;

		public float ItemEndScale => 0f;

		public float CurrencyEndScale => 0f;

		public void PlayFloatingReward(RectTransform sourceTransform, RectTransform targetTransform, Sprite icon, float endScale, Action onComplete)
		{
		}

		public void PlayFloatingRewardInstant(RectTransform sourceTransform, RectTransform targetTransform, Sprite icon, float endScale, Action onComplete)
		{
		}

		private void PlayFloatingRewardInternal(RectTransform sourceTransform, RectTransform targetTransform, Sprite icon, float endScale, float duration, Action onComplete)
		{
		}

		public void Reset()
		{
		}

		private RectTransform CreateFloatingIcon(RectTransform sourceTransform, Sprite icon)
		{
			return null;
		}

		private Vector2 GetPositionInContainer(RectTransform sourceTransform)
		{
			return default(Vector2);
		}
	}
}
