using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingHealthPointIndicator : MonoBehaviour
	{
		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private TMP_Text _hpText;

		private BaseBuilding _building;

		private bool _isEnabled;

		public void Initialize(BaseBuilding building)
		{
		}

		public void SetEnabled(bool enabled)
		{
		}

		private void SetupHealthUI()
		{
		}

		private void OnHealthPointsChanged(float currentHealth)
		{
		}

		private void UpdateHp()
		{
		}
	}
}
