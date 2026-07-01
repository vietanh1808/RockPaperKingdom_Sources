using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.BossChest.UI
{
	public class UIBossChestUpgradesPanel : MonoBehaviour
	{
		[SerializeField]
		private UIBossChestUpgradeItem _itemPrefab;

		[SerializeField]
		private RectTransform _container;

		[SerializeField]
		private HorizontalLayoutGroup _horizontalLayoutGroup;

		[SerializeField]
		private GameObject _selectRuneSubtitle;

		[Header("Reveal Settings")]
		[SerializeField]
		private float _revealDelay;

		[SerializeField]
		private float _rollerDuration;

		[SerializeField]
		private float _revealStaggerDelay;

		[SerializeField]
		private float _cardRevealDelay;

		[Header("Selection Animation Settings")]
		[SerializeField]
		private float _selectAnimationDuration;

		[SerializeField]
		private float _selectDelayAfterAnimation;

		[SerializeField]
		private float _selectMinScale;

		[SerializeField]
		private float _selectMaxScale;

		[Header("Dissolve Settings")]
		[SerializeField]
		private Material _dissolveMaterial;

		[SerializeField]
		private float _dissolveDuration;

		[SerializeField]
		private RectTransform _title;

		[SerializeField]
		private float _titlePopDuration;

		[Header("Audio")]
		[SerializeField]
		private SoundData _dissolveSound;

		[SerializeField]
		private SoundData _upgradeAppearSound;

		[SerializeField]
		private SoundData _wheelSpinSound;

		[SerializeField]
		private SoundData[] _upgradeRevealSounds;

		[Header("Peek")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private UIPeekButton _peekButton;

		[Header("Reroll")]
		[SerializeField]
		private GameObject _rerollObject;

		private static readonly int DissolveProgressProperty;

		private static readonly int DissolveCenterProperty;

		private readonly List<UIBossChestUpgradeItem> _uiUpgradeItems;

		private BossChestUpgradeCollection _upgradeCollection;

		private BossChestUpgradeSystem _bossChestUpgradeSystem;

		private BossChestManager _bossChestManager;

		private GameplayDebugSettings _debugSettings;

		private List<BaseGameplayUpgrade> _upgrades;

		private Action<BaseGameplayUpgrade> _onUpgradeSelectedCallback;

		private Action _onClosedCallback;

		private int _revealedCount;

		public IReadOnlyList<BaseGameplayUpgrade> Upgrades => null;

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
		private void Inject(BossChestUpgradeCollection upgradeCollection, BossChestUpgradeSystem bossChestUpgradeSystem, BossChestManager bossChestManager, GameplayDebugSettings debugSettings)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void PlayDissolveAnimation()
		{
		}

		private void OnDissolveComplete()
		{
		}

		private void ResetDissolveMaterial()
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

		public void Open(List<BaseGameplayUpgrade> upgrades, Action<BaseGameplayUpgrade> onUpgradeSelected, Action onClosed)
		{
		}

		public void Close()
		{
		}

		public void RerollUpgrades()
		{
		}

		private void DestroyAllElements()
		{
		}

		private void CreateAllElements()
		{
		}

		private Sprite[] GetRollerIcons()
		{
			return null;
		}

		private void StartRevealSequence()
		{
		}

		private void OnItemRevealComplete()
		{
		}

		private void OnAllItemsRevealed()
		{
		}

		private void ShowAllCards()
		{
		}

		private void EnableAllInteractions()
		{
		}

		private void OnUpgradeIndexSelected(UIBossChestUpgradeItem uiUpgradeItem)
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
