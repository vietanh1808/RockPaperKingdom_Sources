using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStageModeTabPair : MonoBehaviour
	{
		[Header("Tabs")]
		[SerializeField]
		private ToggleGroup _tabToggleGroup;

		[SerializeField]
		private Toggle _normalTab;

		[SerializeField]
		private Toggle _hardTab;

		[Header("Feature Unlock")]
		[SerializeField]
		private FeatureItemData _hardModeFeatureData;

		[SerializeField]
		private GameObject _hardTabLock;

		[SerializeField]
		private UIButtonClick _hardTabLockButton;

		private StageSystem _stageSystem;

		private FeatureUnlockSystem _featureUnlockSystem;

		private FeatureItem _hardModeFeatureItem;

		public bool IsHardUnlocked { get; private set; }

		public Toggle NormalTab => null;

		public Toggle HardTab => null;

		public event Action<StageModeType> OnModeSelected
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

		[Inject]
		public void Inject(StageSystem stageSystem, FeatureUnlockSystem featureUnlockSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnNormalTabValueChanged(bool isOn)
		{
		}

		private void OnHardTabValueChanged(bool isOn)
		{
		}

		private void SelectMode(StageModeType modeType)
		{
		}

		private void SyncToCurrentMode()
		{
		}

		private void OnHardModeFeatureStatusChanged(FeatureItem featureItem)
		{
		}

		private void RefreshHardTabLock()
		{
		}
	}
}
