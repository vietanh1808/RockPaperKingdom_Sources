using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingStatChangeDisplay : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CProcessQueueCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIBuildingStatChangeDisplay _003C_003E4__this;

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
			public _003CProcessQueueCoroutine_003Ed__26(int _003C_003E1__state)
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
		private Vector3 _spawnOffset;

		[SerializeField]
		private float _delayBetweenDisplays;

		private const string LEVEL_UP_TEXT = "LVL UP";

		private StatChangeItemPool _itemPool;

		private BaseBuilding _building;

		private Queue<string> _changeQueue;

		private Coroutine _processCoroutine;

		private int _activeAnimationsCount;

		private bool _isProcessing;

		private int _lastLevelIndex;

		public bool HasQueuedChanges => false;

		public event Action OnAllAnimationsComplete
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

		[Inject]
		public void Construct(StatChangeItemPool itemPool)
		{
		}

		private void OnDestroy()
		{
		}

		public void Initialize(BaseBuilding building)
		{
		}

		private void Subscribe()
		{
		}

		private void Unsubscribe()
		{
		}

		private void OnStatChanged(StatChangeEventArgs args)
		{
		}

		private void TryEnqueueLevelUp()
		{
		}

		public void EnqueueResourceChange(string title, int amount)
		{
		}

		private void EnqueueValueChange(string statTitle, float delta)
		{
		}

		private void EnqueueMultiplierChange(string statTitle, float delta)
		{
		}

		private void EnqueueChange(string text)
		{
		}

		[IteratorStateMachine(typeof(_003CProcessQueueCoroutine_003Ed__26))]
		private IEnumerator ProcessQueueCoroutine()
		{
			return null;
		}

		private void DisplayStatChange(string text)
		{
		}

		private void OnAnimationComplete()
		{
		}

		private void OnBuildingDestroyed(BaseBuilding building)
		{
		}

		private static string FormatNumber(float value)
		{
			return null;
		}
	}
}
