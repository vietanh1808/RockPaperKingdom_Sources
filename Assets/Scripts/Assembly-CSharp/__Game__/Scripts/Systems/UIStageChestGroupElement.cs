using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStageChestGroupElement : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _groupButton;

		[SerializeField]
		private TMP_Text _stageTitle;

		[SerializeField]
		private Image _stageIcon;

		[SerializeField]
		private List<UIStageRewardElement> _chestElements;

		[Header("Selection")]
		[SerializeField]
		private GameObject _selectedIndicator;

		private int _stageIndex;

		private StageModeType _stageModeType;

		private List<StageChestItem> _chestItems;

		private StageChestSystem _stageChestSystem;

		public int StageIndex => 0;

		public UIStageRewardElement FirstChestElement => null;

		public event Action<int> OnGroupSelected
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

		public void Construct(int stageIndex, StageModeType stageModeType, StageData stageData, List<StageChestItem> chestItems, StageChestSystem stageChestSystem, StageSystem stageSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetSelected(bool isSelected)
		{
		}

		public void RefreshState()
		{
		}

		private void RefreshStageTitle(StageSystem stageSystem)
		{
		}

		private void SetupChestElements()
		{
		}

		private bool IsNextChestReached(int currentIndex)
		{
			return false;
		}

		private void OnDestroy()
		{
		}

		private void OnChestElementClicked(StageChestItem chestItem)
		{
		}

		private void GroupButtonClicked()
		{
		}
	}
}
