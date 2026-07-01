using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Simulation__.Systems.UnitCardGraph
{
	public class UISimulationUnitCardGraphView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDisableLayoutGroupsNextFrame_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UISimulationUnitCardGraphView _003C_003E4__this;

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
			public _003CDisableLayoutGroupsNextFrame_003Ed__9(int _003C_003E1__state)
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

		[SerializeField]
		private RectTransform _layoutRoot;

		[SerializeField]
		private RectTransform _graphContainer;

		[SerializeField]
		private UISimulationUnitCardUpgradeSnapshot _snapshotPrefab;

		private GameSimulationSystem _gameSimulationSystem;

		[Inject]
		private void Inject(GameSimulationSystem gameSimulationSystem)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DrawAllElements()
		{
		}

		[IteratorStateMachine(typeof(_003CDisableLayoutGroupsNextFrame_003Ed__9))]
		private IEnumerator DisableLayoutGroupsNextFrame()
		{
			return null;
		}

		private void SetLayoutGroupsEnabled(bool isEnabled)
		{
		}

		private static Dictionary<string, int> BuildCardOrder(IReadOnlyList<SimulationSnapshot> snapshots)
		{
			return null;
		}
	}
}
