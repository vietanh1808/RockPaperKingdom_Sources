using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Gameplay;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationHpSlider : MonoBehaviour
	{
		[SerializeField]
		private Slider _slider;

		private UnitRepositoryFactory _unitRepositoryFactory;

		private UnitType _unitType;

		private float _initialTotalHp;

		private bool _isInitialized;

		[Inject]
		private void Inject(UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		private void Start()
		{
		}

		public void Initialize(UnitType unitType)
		{
		}

		public void StartTracking()
		{
		}

		public void StopTracking()
		{
		}

		public void UpdateHpValue()
		{
		}

		private void SetupInitialValues()
		{
		}

		private float CalculateTotalHp()
		{
			return 0f;
		}

		private float CalculateCurrentTotalHp()
		{
			return 0f;
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}
	}
}
