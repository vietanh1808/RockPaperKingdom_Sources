using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems._Upgrades
{
	public class UpgradesSimulationSystem
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialize_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UpgradesSimulationSystem _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadGameplayScene_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			private AsyncOperation _003CloadOperation_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunAllStrategies_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UpgradesSimulationSystem _003C_003E4__this;

			private List<GameplaySimulationSettings>.Enumerator _003C_003E7__wrap1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunSingleStage_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UpgradesSimulationSystem _003C_003E4__this;

			public int stageIndex;

			public GameplaySimulationSettings strategySettings;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunStrategyOnAllStages_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UpgradesSimulationSystem _003C_003E4__this;

			public GameplaySimulationSettings strategySettings;

			private int _003CstageIndex_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunWaveTimeoutWatcher_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public UpgradesSimulationSystem _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetupSceneRecorder_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UpgradesSimulationSystem _003C_003E4__this;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnloadGameplayScene_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			private AsyncOperation _003CunloadOperation_003E5__2;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitForStageCompletion_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public UpgradesSimulationSystem _003C_003E4__this;

			private CancellationTokenSource _003CtimeoutCts_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		private const float WAVE_TIMEOUT_SECONDS = 45f;

		private readonly UpgradesSimulationConfig _upgradesSimulationConfig;

		private readonly StageSystem _stageSystem;

		private readonly StagesCollection _stagesCollection;

		private readonly GameplayDebugSettings _gameplayDebugSettings;

		private readonly int _instanceIndex;

		private readonly string _csvOutputPath;

		private readonly bool _isStandaloneInstance;

		private GameplaySimulationSettings _currentStrategy;

		private int _currentStageIndex;

		private GameplayLogRecorder _currentLogRecorder;

		private TaskCompletionSource<bool> _stageCompletionSource;

		public Dictionary<GameplaySimulationSettings, StrategyLog> StagesByStrategy { get; }

		public List<GameplaySimulationSettings> Strategies => null;

		public List<StageData> SimulatedStages { get; }

		public bool IsSimulationFinished { get; private set; }

		public bool IsLoadedFromCsv { get; private set; }

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

		public UpgradesSimulationSystem(UpgradesSimulationConfig upgradesSimulationConfig, StageSystem stageSystem, StagesCollection stagesCollection, GameplayDebugSettings gameplayDebugSettings)
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__32))]
		public Task Initialize()
		{
			return null;
		}

		private void PrepareSimulation()
		{
		}

		[AsyncStateMachine(typeof(_003CRunAllStrategies_003Ed__34))]
		private Task RunAllStrategies()
		{
			return null;
		}

		private List<GameplaySimulationSettings> GetStrategiesForCurrentInstance()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRunStrategyOnAllStages_003Ed__36))]
		private Task RunStrategyOnAllStages(GameplaySimulationSettings strategySettings)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRunSingleStage_003Ed__37))]
		private Task RunSingleStage(int stageIndex, GameplaySimulationSettings strategySettings)
		{
			return null;
		}

		private void SetupDebugSettings(GameplaySimulationSettings strategySettings)
		{
		}

		private void SetupStageSystem(int stageIndex)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadGameplayScene_003Ed__40))]
		private Task LoadGameplayScene()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSetupSceneRecorder_003Ed__41))]
		private Task SetupSceneRecorder()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWaitForStageCompletion_003Ed__42))]
		private Task WaitForStageCompletion()
		{
			return null;
		}

		private void OnStageCompleted()
		{
		}

		private void SaveStageResult()
		{
		}

		private void CleanupRecorder()
		{
		}

		[AsyncStateMachine(typeof(_003CRunWaveTimeoutWatcher_003Ed__46))]
		private Task RunWaveTimeoutWatcher(CancellationToken cancellationToken)
		{
			return null;
		}

		private void ForceUnstuck()
		{
		}

		[AsyncStateMachine(typeof(_003CUnloadGameplayScene_003Ed__48))]
		private Task UnloadGameplayScene()
		{
			return null;
		}

		private void FinishSimulation()
		{
		}

		private void ExportResults()
		{
		}

		private SceneContext GetSceneContext(Scene scene)
		{
			return null;
		}

		private GameplayLogRecorder GetGameplayLogRecorder(SceneContext sceneContext)
		{
			return null;
		}

		private GameplayDebugStageSettings GetCurrentStageSettings()
		{
			return null;
		}
	}
}
