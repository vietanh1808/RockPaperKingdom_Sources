using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationUnitSelectPanel : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _closeButtonClick;

		[SerializeField]
		private UIUnitSelectElement _unitSelectPrefab;

		[SerializeField]
		private RectTransform _unitSelectContainer;

		private readonly List<UIUnitSelectElement> _unitSelectElements;

		private BattleSimulationSystem _battleSimulationSystem;

		private UIBattleSimulationSceneNavigation _uiBattleSimulationSceneNavigation;

		[Inject]
		private void Inject(BattleSimulationSystem battleSimulationSystem, UIBattleSimulationSceneNavigation uiBattleSimulationSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CreateAllElements()
		{
		}

		private void DestroyAllElements()
		{
		}

		private void OnCloseButtonHandler()
		{
		}

		private void OnUnitSelectClicked(UnitBattleSimulationData unitBattleSimulationData)
		{
		}
	}
}
