using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationUnitStatsPanel : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _titleText;

		[SerializeField]
		private UIButtonClick _closeButtonClick;

		[SerializeField]
		private UISliderElement _attackDamageSlider;

		[SerializeField]
		private UISliderElement _attackSpeedSlider;

		[SerializeField]
		private UISliderElement _healthSlider;

		[SerializeField]
		private UISliderElement _attackRangeSlider;

		[SerializeField]
		private UISliderElement _moveSpeedSlider;

		[SerializeField]
		private UISliderElement _attackRadiusSlider;

		private UIBattleSimulationSceneNavigation _uiBattleSimulationSceneNavigation;

		private UnitBattleSimulationStats _unitBattleSimulationStats;

		[Inject]
		private void Inject(UIBattleSimulationSceneNavigation uiBattleSimulationSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetupForAttacker(string title, UnitBattleSimulationStats unitBattleSimulationStats, UnitBattleSimulationData unitBattleSimulationData)
		{
		}

		private void InitializeSliders()
		{
		}

		private void OnAttackDamageChanged(float value)
		{
		}

		private void OnAttackSpeedChanged(float value)
		{
		}

		private void OnHealthChanged(float value)
		{
		}

		private void OnAttackRangeChanged(float value)
		{
		}

		private void OnMoveSpeedChanged(float value)
		{
		}

		private void OnAttackRadiusChanged(float value)
		{
		}

		private void OnCloseButtonHandler()
		{
		}
	}
}
