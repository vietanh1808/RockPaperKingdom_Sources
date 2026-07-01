using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationUnitAmountPanel : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private UIButtonClick _closeButtonClick;

		[SerializeField]
		private UIUnitAmountElement _unitAmountPrefab;

		[SerializeField]
		private RectTransform _unitAmountContainer;

		private readonly List<UIUnitAmountElement> _uiUnitAmountElements;

		private Dictionary<UnitBattleSimulationData, int> _unitAmountByData;

		private UIBattleSimulationSceneNavigation _uiBattleSimulationSceneNavigation;

		[Inject]
		private void Inject(UIBattleSimulationSceneNavigation uiBattleSimulationSceneNavigation)
		{
		}

		public void SetupData(string title, Dictionary<UnitBattleSimulationData, int> unitAmountByData)
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

		private void OnUnitAmountChanged(UnitData unitData, int unitAmount)
		{
		}
	}
}
