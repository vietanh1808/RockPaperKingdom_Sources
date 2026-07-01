using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay.Boss
{
	public class UIBossHealthPoints : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootContainer;

		[SerializeField]
		private TMP_Text _healthText;

		[SerializeField]
		private Slider _healthSlider;

		private UnitHealthPoints _currentHealthPoints;

		public event Action OnDisplayed
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

		public event Action OnHidden
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

		public void Show(UnitHealthPoints currentHealthPoints)
		{
		}

		public void Hide()
		{
		}

		private void OnHealthPointsChanged(float health)
		{
		}

		private void RefreshUI()
		{
		}
	}
}
