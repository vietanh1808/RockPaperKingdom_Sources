using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	public class SpriteFlickerController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlickerLoop_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpriteFlickerController _003C_003E4__this;

			private WaitForSeconds _003CstepWait_003E5__2;

			private WaitForSeconds _003CdisplayWait_003E5__3;

			private int _003Cs_003E5__4;

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
			public _003CFlickerLoop_003Ed__9(int _003C_003E1__state)
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
		private SpriteFlickerEffect[] _effects;

		[SerializeField]
		private float[] _alphaSteps;

		[SerializeField]
		private float _stepDuration;

		[SerializeField]
		private float _displayDuration;

		private Coroutine _coroutine;

		private int _lastStep;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CFlickerLoop_003Ed__9))]
		private IEnumerator FlickerLoop()
		{
			return null;
		}

		private void ShowAll()
		{
		}

		private void HideAll()
		{
		}
	}
}
