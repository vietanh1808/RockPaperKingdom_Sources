using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public abstract class UIBaseFortuneWheelAnimation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRotateWheelCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int startIndex;

			public UIBaseFortuneWheelAnimation _003C_003E4__this;

			public int numberOfRotations;

			private int _003Crotation_003E5__2;

			private int _003Ctick_003E5__3;

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
			public _003CRotateWheelCoroutine_003Ed__17(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CRotateWheelToSelectedCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int startIndex;

			public UIBaseFortuneWheelAnimation _003C_003E4__this;

			private int _003Ci_003E5__2;

			private int _003CelementIndex_003E5__3;

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
			public _003CRotateWheelToSelectedCoroutine_003Ed__18(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShowFocusMarks_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public List<int> indexes;

			public int offset;

			public UIBaseFortuneWheelAnimation _003C_003E4__this;

			public float focusDuration;

			public float delay;

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
			public _003CShowFocusMarks_003Ed__19(int _003C_003E1__state)
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

		[Header("Audio")]
		[SerializeField]
		private SoundData _tickSound;

		[SerializeField]
		private SoundData[] _selectSounds;

		protected List<int> PreviewIndexes;

		protected List<int> FocusIndexes;

		protected List<UIFortuneWheelElement> UIElements;

		protected FortuneWheelSystem FortuneWheelSystem;

		private AnimationCurve _animationDelayCurve;

		private float _currentDelay;

		private float _elapsedTime;

		public event Action OnCompleted
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
		private void Inject(FortuneWheelSystem fortuneWheelSystem)
		{
		}

		public void Initialize(AnimationCurve animationDelayCurve)
		{
		}

		public abstract void RefreshElements(List<UIFortuneWheelElement> uiElements);

		public abstract void StartAnimation();

		protected abstract void RotateWheelCompleted(int startIndex);

		[IteratorStateMachine(typeof(_003CRotateWheelCoroutine_003Ed__17))]
		protected IEnumerator RotateWheelCoroutine(int startIndex, int numberOfRotations)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRotateWheelToSelectedCoroutine_003Ed__18))]
		protected IEnumerator RotateWheelToSelectedCoroutine(int startIndex)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowFocusMarks_003Ed__19))]
		protected IEnumerator ShowFocusMarks(List<int> indexes, int offset, float delay, float focusDuration = 0.35f)
		{
			return null;
		}

		protected abstract IEnumerator HandleSelectedElements(int elementIndex);

		protected void InvokeOnCompleted()
		{
		}

		protected void ResetDelay()
		{
		}

		protected void PlayTick()
		{
		}

		protected void PlaySelectSound(int index)
		{
		}

		private void UpdateCurrentDelay()
		{
		}
	}
}
