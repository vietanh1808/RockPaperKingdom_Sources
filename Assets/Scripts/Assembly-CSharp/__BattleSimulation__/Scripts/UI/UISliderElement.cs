using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UISliderElement : MonoBehaviour
	{
		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private TMP_Text _currentValueText;

		[SerializeField]
		private TMP_Text _minValueText;

		[SerializeField]
		private TMP_Text _maxValueText;

		[Header("Settings")]
		[SerializeField]
		private float _step;

		public event Action<float> OnValueChanged
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetupInitialValue(string title, float currentValue, float minValue, float maxValue, float step = 0.1f)
		{
		}

		private void OnSliderChanged(float value)
		{
		}
	}
}
