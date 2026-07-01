using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zenject;
using __Simulation__.SimulationModules;
using __Simulation__.Systems.SimulationTime;

namespace __Simulation__.Systems
{
	public class GameSimulationSystem
	{
		private readonly DiContainer _diContainer;

		private readonly SimulationConfig _simulationConfig;

		private readonly List<ISimulationModule> _simulationModules;

		private readonly SimulationTimeSystem _simulationTimeSystem;

		private readonly SimulationSnapshot _simulationSnapshot;

		public List<SimulationSnapshot> SnapshotRecords { get; }

		public bool IsSimulationFinished { get; private set; }

		public event Action OnSimulationFinished
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

		public GameSimulationSystem(DiContainer diContainer, SimulationConfig simulationConfig, SimulationTimeSystem simulationTimeSystem, SimulationSnapshot simulationSnapshot)
		{
		}

		public void Initialize()
		{
		}

		private void Simulate()
		{
		}

		private void IterateModules()
		{
		}

		private void RecordSnapshot()
		{
		}
	}
}
