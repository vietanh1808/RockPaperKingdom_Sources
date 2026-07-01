using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class UIUpgradesPanel : MonoBehaviour
	{
		[SerializeField]
		private UIUpgradeItem _itemPrefab;

		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private HorizontalLayoutGroup _horizontalLayoutGroup;

		[Header("Animation Settings")]
		[SerializeField]
		private float _selectAnimationDuration;

		[SerializeField]
		private float _selectDelayAfterAnimation;

		[SerializeField]
		private float _selectMinScale;

		[SerializeField]
		private float _selectMaxScale;

		[SerializeField]
		private float _rerollDelay;

		[SerializeField]
		private float _refreshDelay;

		[Header("Audio")]
		[SerializeField]
		private SoundData _upgradeAppearSound;

		[Header("Peek")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private UIPeekButton _peekButton;

		private GameplayUpgradesSystem _gameplayUpgradesSystem;

		private GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private UnitCardSystem _unitCardSystem;

		private RarityConfig _rarityConfig;

		private Action _onClosedCallback;

		public List<UIUpgradeItem> UIUpgradeItems { get; }

		public event Action OnUpgradesSpawned
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

		public event Action OnUpgradeSelected
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
		private void Inject(GameplayUpgradesSystem gameplayUpgradesSystem, GameplayUpgradesPresenter gameplayUpgradesPresenter, UnitCardSystem unitCardSystem, RarityConfig rarityConfig)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open(Action onClosed)
		{
		}

		public void Close()
		{
		}

		public void RerollUpgrades()
		{
		}

		private void SetupPeekButton()
		{
		}

		private void CleanupPeekButton()
		{
		}

		private void OnPeekDown()
		{
		}

		private void OnPeekUp()
		{
		}

		private void RefreshCards()
		{
		}

		private void DestroyAllElements()
		{
		}

		private void CreateAllElements()
		{
		}

		private UnitCardItem GetUnitCardItem(BaseGameplayUpgrade upgrade)
		{
			return null;
		}

		private void OnUpgradeIndexSelected(UIUpgradeItem uiUpgradeItem)
		{
		}

		private void ShowSelectedAnimation(int index)
		{
		}

		private void ApplyUpgrade(BaseGameplayUpgrade upgrade)
		{
		}
	}
}
