using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.UI;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIUnitAmountElement : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _unitTitleText;

		[SerializeField]
		private UIButtonClick _addUnitButtonClick;

		[SerializeField]
		private UIButtonClick _removeUnitButtonClick;

		private UnitData _unitData;

		private int _unitAmount;

		private string _unitTitle;

		public event Action<UnitData, int> OnUnitAmountChanged
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

		public void Construct(string title, UnitData unitData, int unitAmount)
		{
		}

		public void Construct(UnitData unitData, int unitAmount)
		{
		}

		private void OnAddUnitButtonClickHandler()
		{
		}

		private void OnRemoveUnitButtonClickHandler()
		{
		}

		private void RefreshView()
		{
		}
	}
}
