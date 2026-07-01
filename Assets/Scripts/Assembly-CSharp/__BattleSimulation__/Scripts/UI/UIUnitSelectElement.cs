using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIUnitSelectElement : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _unitTitleText;

		[SerializeField]
		private UIButtonClick _selectButtonClick;

		private UnitBattleSimulationData _unitBattleSimulationData;

		public event Action<UnitBattleSimulationData> OnUnitSelectClicked
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

		public void Construct(UnitBattleSimulationData unitBattleSimulationData)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
