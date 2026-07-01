using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class Chain : AbilityObjectComponent
	{
		[CompilerGenerated]
		private sealed class _003CSpawnChain_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Chain _003C_003E4__this;

			private float _003CpositionY_003E5__2;

			private List<AbilityObject> _003CeffectObjects_003E5__3;

			private List<BaseUnit>.Enumerator _003C_003E7__wrap3;

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
			public _003CSpawnChain_003Ed__8(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private LineRenderer _lineRenderer;

		[SerializeField]
		private float _cornerRadius;

		[SerializeField]
		private int _cornerSegments;

		private List<BaseUnit> _enemies;

		private List<Vector3> _keyPositions;

		private AbilityObject _abilityObject;

		private Vector3 _initialPosition;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnChain_003Ed__8))]
		private IEnumerator SpawnChain()
		{
			return null;
		}

		private Vector3[] BuildSmoothedPath(List<Vector3> keyPoints)
		{
			return null;
		}
	}
}
