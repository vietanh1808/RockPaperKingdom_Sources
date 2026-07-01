using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __BattleSimulation__.Scripts.UI
{
	public class UIBattleSimulationHpTracker : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIBattleSimulationHpTracker _003C_003E4__this;

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
			public _003CUpdateCoroutine_003Ed__15(int _003C_003E1__state)
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
		private UIBattleSimulationHpSlider _defenderHpSlider;

		[SerializeField]
		private UIBattleSimulationHpSlider _attackerHpSlider;

		private readonly List<UIBattleSimulationHpSlider> _allSliders;

		private Coroutine _updateCoroutine;

		private bool _isTracking;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void StartTracking()
		{
		}

		public void StopTracking()
		{
		}

		private void InitializeSliders()
		{
		}

		private void StartTrackingAllSliders()
		{
		}

		private void StopTrackingAllSliders()
		{
		}

		private void UpdateAllSliders()
		{
		}

		private void StartUpdateCoroutine()
		{
		}

		private void StopUpdateCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateCoroutine_003Ed__15))]
		private IEnumerator UpdateCoroutine()
		{
			return null;
		}
	}
}
