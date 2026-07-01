using System;
using System.Runtime.CompilerServices;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	public class RockPaperScissorsSystem
	{
		private readonly GameplayInventorySystem _gameplayInventorySystem;

		private readonly GridExpandSystem _gridExpandSystem;

		private readonly GameplayConfig _gameplayConfig;

		private readonly RockPaperScissorsConfig _config;

		private readonly StageSystem _stageSystem;

		private readonly WaveSystem _waveSystem;

		private int _playIndex;

		private int _sessionGameplayCardsCount;

		private int _totalMysteryCardsReceived;

		private RPSOutcomeType? _cachedOutcomeType;

		private bool _isFirstPlayInSession;

		public RockPaperScissorsConfig Config => null;

		public bool HasReachedSessionCardLimit => false;

		public event Action OnPlayCompleted
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

		public RockPaperScissorsSystem(GameplayInventorySystem gameplayInventorySystem, GridExpandSystem gridExpandSystem, GameplayConfig gameplayConfig, RockPaperScissorsConfig config, StageSystem stageSystem, WaveSystem waveSystem)
		{
		}

		public void ResetForNewStage()
		{
		}

		public void ResetSessionCardCount()
		{
		}

		public bool CanPlay()
		{
			return false;
		}

		public int GetCurrentResourceAmount()
		{
			return 0;
		}

		public bool TryConsumeEntry()
		{
			return false;
		}

		public RPSGameResult Play(RPSChoice playerChoice)
		{
			return null;
		}

		public void ApplyReward(RPSOutcomeData outcome)
		{
		}

		private PredefinedRpsPlay ResolvePredefinedPlay()
		{
			return null;
		}

		private RPSOutcomeData ResolveOutcome(RPSResultType resultType, PredefinedRpsPlay predefinedPlay)
		{
			return null;
		}

		private RPSOutcomeData ResolveWinOutcome(PredefinedRpsPlay predefinedPlay)
		{
			return null;
		}

		private RPSResultType EnforceResultType(RPSResultType resultType, PredefinedRpsPlay predefinedPlay)
		{
			return default(RPSResultType);
		}

		private bool ShouldForceMapExpandLose(PredefinedRpsPlay predefinedPlay)
		{
			return false;
		}

		private RPSOutcomeType GetOrResolveOutcomeType(PredefinedRpsPlay predefinedPlay)
		{
			return default(RPSOutcomeType);
		}

		private RPSOutcomeType EnforceMysteryCardGuarantee(RPSOutcomeType outcomeType)
		{
			return default(RPSOutcomeType);
		}

		private RPSOutcomeType EnforceSessionLimits(RPSOutcomeType outcomeType)
		{
			return default(RPSOutcomeType);
		}

		private RPSOutcomeData CreateDrawRefundOutcome()
		{
			return null;
		}

		private RPSChoice ResolveOpponentChoice(RPSChoice playerChoice, RPSResultType resultType)
		{
			return default(RPSChoice);
		}

		private RPSChoice GetLosingChoice(RPSChoice playerChoice)
		{
			return default(RPSChoice);
		}

		private RPSChoice GetWinningChoice(RPSChoice playerChoice)
		{
			return default(RPSChoice);
		}
	}
}
