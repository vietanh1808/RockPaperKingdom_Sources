using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UnitHealthPointIndicator : MonoBehaviour
	{
		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private TMP_Text _hpText;

		private BaseUnit _unit;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
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
