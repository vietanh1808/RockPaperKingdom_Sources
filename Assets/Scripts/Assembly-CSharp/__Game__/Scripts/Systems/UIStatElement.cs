using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStatElement : MonoBehaviour
	{
		[SerializeField]
		private Image _statIcon;

		[SerializeField]
		private TMP_Text _statValue;

		[SerializeField]
		private TMP_Text _statTitle;

		private StatInfo _statInfo;

		private float _currentValue;

		private Tween _fadeTween;

		private Tween _valueTween;

		public void SetInfo(StatInfo statInfo)
		{
		}

		public void SetValue(float value)
		{
		}

		public void SetValueFormatted(float value, string format)
		{
		}

		public void SetValueFormattedAnimated(float newValue, string format, bool withFadeAnimation = true)
		{
		}

		private void AnimateValueIncrementFormatted(float targetValue, string format)
		{
		}

		public void SetValueAnimated(float newValue, bool withFadeAnimation = true)
		{
		}

		private void AnimateValueIncrement(float targetValue)
		{
		}

		private string FormatValue(float value)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
