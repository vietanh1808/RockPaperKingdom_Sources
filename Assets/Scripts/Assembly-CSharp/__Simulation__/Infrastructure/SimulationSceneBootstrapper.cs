using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;
using __Simulation__.Systems;
using __Simulation__.Systems.EnergyGraph;
using __Simulation__.Systems.ExperienceGraph;
using __Simulation__.Systems.InventoryGraph;
using __Simulation__.Systems.PlayerStatsGraph;

namespace __Simulation__.Infrastructure
{
	public class SimulationSceneBootstrapper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimulationSceneBootstrapper _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStart_003Ed__9(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private GameSimulationSystem _gameSimulationSystem;

		private SimulationCsvExportSystem _simulationCsvExportSystem;

		private SimulationInventoryGraphSystem _inventoryGraphSystem;

		private SimulationExperienceGraphSystem _experienceGraphSystem;

		private SimulationPlayerUpgradesGraphSystem _playerUpgradesGraphSystem;

		private SimulationEnergyGraphSystem _energyGraphSystem;

		private SimulationPlayerStatsGraphSystem _playerStatsGraphSystem;

		private UIProjectHolder _uiProjectHolder;

		[Inject]
		private void Inject(GameSimulationSystem gameSimulationSystem, SimulationCsvExportSystem simulationCsvExportSystem, SimulationInventoryGraphSystem inventoryGraphSystem, SimulationExperienceGraphSystem experienceGraphSystem, SimulationPlayerUpgradesGraphSystem playerUpgradesGraphSystem, SimulationEnergyGraphSystem energyGraphSystem, SimulationPlayerStatsGraphSystem playerStatsGraphSystem, UIProjectHolder uiProjectHolder)
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
		private IEnumerator Start()
		{
			return null;
		}
	}
}
