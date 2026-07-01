using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Services.ABTest;
using __Game__.Scripts.Services.Random;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.Infrastructure
{
	public class ProjectBootstrapper : MonoBehaviour
	{
		private RandomService _randomService;

		private GameStateMachine _gameStateMachine;

		private ISaveLoadDataService _saveLoadDataService;

		private SettingService _settingService;

		private RewardSystem _rewardSystem;

		private EnergySystem _energySystem;

		private StageSystem _stageSystem;

		private StageChestSystem _stageChestSystem;

		private EquipmentEquipAlertSystem _equipmentEquipAlertSystem;

		private EquipmentUpgradeAlertSystem _equipmentUpgradeAlertSystem;

		private HeroSystem _heroSystem;

		private HeroUpgradeAlertSystem _heroUpgradeAlertSystem;

		private HeroNewAlertSystem _heroNewAlertSystem;

		private UnitCardSystem _unitCardSystem;

		private ChestAvailableUnitCardProvider _chestAvailableUnitCardProvider;

		private UnitCardUpgradeAlertSystem _unitCardUpgradeAlertSystem;

		private UnitCardNewAlertSystem _unitCardNewAlertSystem;

		private EquipmentMergeSystem _equipmentMergeSystem;

		private StaticStatSystem _staticStatSystem;

		private InAppPurchaseService _inAppPurchaseService;

		private IAdsService _adsService;

		private DailyRewardsSystem _dailyRewardsSystem;

		private PlayerUpgradesSystem _playerUpgradesSystem;

		private PatrolRewardsSystem _patrolRewardsSystem;

		private QuickPatrolSystem _quickPatrolSystem;

		private FeatureUnlockSystem _featureUnlockSystem;

		private ProjectSettings _projectSettings;

		private RestoreGameplayRuntimeData _restoreGameplayRuntimeData;

		private TutorialsGameplayRuntimeData _tutorialsGameplayRuntimeData;

		private MetaQuestSystem _metaQuestSystem;

		private SpeedUpPurchaseSystem _speedUpPurchaseSystem;

		private AppReviewSystem _appReviewSystem;

		private LocalNotificationService _localNotificationService;

		private ABTestService _abTestService;

		private ArenaChestSystem _arenaChestSystem;

		private ArenaTicketSystem _arenaTicketSystem;

		private PlayerPowerSystem _playerPowerSystem;

		private DailyStreakQuestSystem _dailyStreakQuestSystem;

		private PlayerInstallTracker _playerInstallTracker;

		[Inject]
		private void Inject(RandomService randomService, ProjectSettings projectSettings, GameStateMachine gameStateMachine, ISaveLoadDataService saveLoadDataService, SettingService settingService, RewardSystem rewardSystem, EnergySystem energySystem, StageSystem stageSystem, StageChestSystem stageChestSystem, EquipmentEquipAlertSystem equipmentEquipAlertSystem, EquipmentMergeSystem equipmentMergeSystem, StaticStatSystem staticStatSystem, EquipmentUpgradeAlertSystem equipmentUpgradeAlertSystem, HeroSystem heroSystem, HeroUpgradeAlertSystem heroUpgradeAlertSystem, HeroNewAlertSystem heroNewAlertSystem, UnitCardSystem unitCardSystem, ChestAvailableUnitCardProvider chestAvailableUnitCardProvider, UnitCardUpgradeAlertSystem unitCardUpgradeAlertSystem, UnitCardNewAlertSystem unitCardNewAlertSystem, InAppPurchaseService inAppPurchaseService, IAdsService adsService, DailyRewardsSystem dailyRewardsSystem, PlayerUpgradesSystem playerUpgradesSystem, PatrolRewardsSystem patrolRewardsSystem, QuickPatrolSystem quickPatrolSystem, FeatureUnlockSystem featureUnlockSystem, RestoreGameplayRuntimeData restoreGameplayRuntimeData, TutorialsGameplayRuntimeData tutorialsGameplayRuntimeData, MetaQuestSystem metaQuestSystem, SpeedUpPurchaseSystem speedUpPurchaseSystem, AppReviewSystem appReviewSystem, LocalNotificationService localNotificationService, ABTestService abTestService, ArenaChestSystem arenaChestSystem, ArenaTicketSystem arenaTicketSystem, PlayerPowerSystem playerPowerSystem, DailyStreakQuestSystem dailyStreakQuestSystem, PlayerInstallTracker playerInstallTracker)
		{
		}

		private void Awake()
		{
		}

		private void BootstrapSimulation()
		{
		}

		private void BootstrapGame()
		{
		}

		private void Initialize()
		{
		}

		private void EnterInitialState()
		{
		}

		private void EnterToLoadingState()
		{
		}
	}
}
