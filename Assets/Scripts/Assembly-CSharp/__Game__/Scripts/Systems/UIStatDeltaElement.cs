using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStatDeltaElement : MonoBehaviour
	{
		private const float ANIMATION_DURATION = 0.6f;

		private const float SCALE_PUNCH = 1.1f;

		private const float SCALE_DURATION = 0.3f;

		[SerializeField]
		private Image _statIcon;

		[SerializeField]
		private TMP_Text _statValue;

		[SerializeField]
		private TMP_Text _statDelta;

		[SerializeField]
		private TMP_Text _statTitle;

		private Tween _fadeTween;

		private Tween _valueTween;

		private Tween _deltaTween;

		private float _currentValue;

		private float _currentDelta;

		public void SetInfo(StatInfo statInfo)
		{
		}

		public void SetValue(float baseValue, float finalValue)
		{
		}

		public void SetValueAnimated(float newBaseValue, float newFinalValue, bool withFadeAnimation = true)
		{
		}

		private void OnDestroy()
		{
		}

		private void ApplyDelta(float delta)
		{
		}

		private void KillTweens()
		{
		}

		private void PlayFadeAnimation(bool enabled)
		{
		}

		private void AnimateValue(float targetValue)
		{
		}

		private void AnimateDelta(float targetDelta)
		{
		}

		private string FormatValue(float value)
		{
			return null;
		}

		private string FormatDelta(float delta)
		{
			return null;
		}
	}
}
