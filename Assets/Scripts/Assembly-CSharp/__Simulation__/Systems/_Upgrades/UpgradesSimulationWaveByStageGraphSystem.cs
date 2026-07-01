using __Game__.Scripts.Gameplay;

namespace __Simulation__.Systems._Upgrades
{
	public class UpgradesSimulationWaveByStageGraphSystem : BaseUpgradesSimulationGraphSystem
	{
		private readonly UpgradesSimulationSystem _upgradesSimulationSystem;

		private int _stageIndex;

		private PowerLogType _powerLogType;

		public int StageIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public PowerLogType PowerLogType
		{
			set
			{
			}
		}

		public UpgradesSimulationWaveByStageGraphSystem(UpgradesSimulationSystem upgradesSimulationSystem)
		{
		}

		private void Initialize()
		{
		}
	}
}
