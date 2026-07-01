using System.ComponentModel;
using SRDebugger;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Services
{
	public class MenuStateDebugContainer
	{
		private readonly DebuggerConfig _debuggerConfig;

		private readonly ISaveLoadDataService _saveLoadDataService;

		private readonly PlayerLevelSystem _playerLevelSystem;

		private readonly InventorySystem _inventorySystem;

		private readonly EnergySystem _energySystem;

		private readonly StageSystem _stageSystem;

		private readonly HeroSystem _heroSystem;

		private readonly HeroConfig _heroConfig;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly UnitCardConfig _unitCardConfig;

		private readonly ApplicationLifecycleService _applicationLifecycleService;

		private readonly LocalNotificationService _localNotificationService;

		private readonly ArenaSystem _arenaSystem;

		private readonly ArenaTicketSystem _arenaTicketSystem;

		private readonly ArenaChestSystem _arenaChestSystem;

		private readonly HardModeUnlockDebugAction _hardModeUnlockDebugAction;

		[Category("1. Inventory")]
		[NumberRange(0.0, 2147483647.0)]
		public int Money
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("1. Inventory")]
		[NumberRange(0.0, 2147483647.0)]
		public int Gems
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("1. Inventory")]
		[NumberRange(0.0, 30.0)]
		public int Energy
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("1. Inventory")]
		public int AllInventory
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("1. Inventory")]
		[NumberRange(0.0, 2147483647.0)]
		public int DarkStars
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("4. Progression")]
		[NumberRange(0.0, 2147483647.0)]
		public int NormalStage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("4. Progression")]
		[NumberRange(0.0, 2147483647.0)]
		public int HardStage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("4. Progression")]
		[NumberRange(0.0, 2147483647.0)]
		public int ArenaRating
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Category("4. Progression")]
		[NumberRange(0.0, 10.0)]
		public int ArenaTickets
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MenuStateDebugContainer(DebuggerConfig debuggerConfig, ISaveLoadDataService saveLoadDataService, PlayerLevelSystem playerLevelSystem, InventorySystem inventorySystem, EnergySystem energySystem, StageSystem stageSystem, HeroSystem heroSystem, HeroConfig heroConfig, UnitCardSystem unitCardSystem, UnitCardConfig unitCardConfig, DebugService debugService, ApplicationLifecycleService applicationLifecycleService, LocalNotificationService localNotificationService, ArenaSystem arenaSystem, ArenaTicketSystem arenaTicketSystem, ArenaChestSystem arenaChestSystem, HardModeUnlockDebugAction hardModeUnlockDebugAction)
		{
		}

		[Category("2. Materials")]
		public void AddMaterials()
		{
		}

		[Category("2. Materials")]
		public void RemoveMaterials()
		{
		}

		[Category("2. Keys")]
		public void AddKeys()
		{
		}

		[Category("3. Collectible")]
		public void UnlockCollectibles()
		{
		}

		[Category("3. Collectible")]
		public void LockCollectibles()
		{
		}

		[Category("4. Progression")]
		public void PlayerLevelUp()
		{
		}

		[Category("4. Progression")]
		public void ResetArenaProgress()
		{
		}

		private void SetStageForMode(StageModeType modeType, int value)
		{
		}

		[Category("4. Progression")]
		public void UnlockHardMode()
		{
		}

		[Category("5. Debug Time")]
		public void AddHour()
		{
		}

		[Category("5. Debug Time")]
		public void AddDay()
		{
		}

		[Category("6. Reset")]
		public void ClearAllData()
		{
		}

		[Category("7. Notifications")]
		public void SendTestNotification()
		{
		}
	}
}
