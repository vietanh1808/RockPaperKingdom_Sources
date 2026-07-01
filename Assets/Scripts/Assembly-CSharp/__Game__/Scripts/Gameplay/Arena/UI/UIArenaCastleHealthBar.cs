using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaCastleHealthBar : MonoBehaviour
	{
		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private TMP_Text _hpText;

		private BuildHealthPoints _healthPoints;

		public void Initialize(Castle castle)
		{
		}

		private void OnHealthPointsChanged(float currentHealth)
		{
		}

		private void UpdateDisplay()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
