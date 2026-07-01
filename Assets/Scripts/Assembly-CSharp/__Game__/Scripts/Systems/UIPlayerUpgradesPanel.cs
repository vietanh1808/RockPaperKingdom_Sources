using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerUpgradesPanel : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private RectTransform _scrollContainer;

		[SerializeField]
		private UIPlayerUpgradeElement _playerUpgradeElement;

		[SerializeField]
		private UIPlayerUpgradeMessage _playerUpgradeMessage;

		private const int ELEMENT_HEIGHT = 300;

		private readonly List<UIPlayerUpgradeElement> _upgradeElements;

		private readonly Dictionary<int, UIPlayerUpgradeElement> _upgradeElementsByLevel;

		private PlayerUpgradesConfig _playerUpgradesConfig;

		private PlayerUpgradesSystem _playerUpgradesSystem;

		private PlayerLevelSystem _playerLevelSystem;

		private UIPlayerUpgradeElement _previousElementLevelRequired;

		public event Action OnUpgradeElementsCreated
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
		public void Inject(PlayerUpgradesConfig playerUpgradesConfig, PlayerUpgradesSystem playerUpgradesSystem, PlayerLevelSystem playerLevelSystem)
		{
		}

		private void Awake()
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

		private void CreateUpgradeElement(int elementIndex)
		{
		}

		private void SetupView()
		{
		}

		private void RefreshLevelRequired()
		{
		}

		private void ShowLevelReady()
		{
		}

		private void OnUpgradeIndexChanged()
		{
		}

		private void RefreshNextElementAlert()
		{
		}

		private void RefreshScrollPosition()
		{
		}

		private void ShowUpgradeMessage(int index, PlayerUpgradeData data, Transform target)
		{
		}

		private int GetMaxAvailableLevel()
		{
			return 0;
		}

		private float GetCurrentScrollPosition()
		{
			return 0f;
		}

		private int GetNextRequiredLevel(int elementIndex)
		{
			return 0;
		}
	}
}
