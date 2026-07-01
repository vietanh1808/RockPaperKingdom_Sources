using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using Zenject;
using __Simulation__.Systems._Upgrades;

namespace __Simulation__.Infrastructure
{
	public class SimulationUpgradesSceneBootstrapper : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunSimulation_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SimulationUpgradesSceneBootstrapper _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private UpgradesSimulationSystem _upgradesSimulationSystem;

		private UISimulationChoicePanel _choicePanel;

		[Inject]
		private void Inject(UpgradesSimulationSystem upgradesSimulationSystem, UISimulationChoicePanel choicePanel)
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnRunSimulation()
		{
		}

		[AsyncStateMachine(typeof(_003CRunSimulation_003Ed__6))]
		private void RunSimulation()
		{
		}

		private void LoadCsvFile(string filePath)
		{
		}

		private static void ApplySimulationPerformanceSettings()
		{
		}
	}
}
