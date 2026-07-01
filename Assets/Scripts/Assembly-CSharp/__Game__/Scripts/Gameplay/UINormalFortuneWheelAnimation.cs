using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class UINormalFortuneWheelAnimation : UIBaseFortuneWheelAnimation
	{
		[CompilerGenerated]
		private sealed class _003CHandleSelectedElements_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UINormalFortuneWheelAnimation _003C_003E4__this;

			public int elementIndex;

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
			public _003CHandleSelectedElements_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CPreviewWheelCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UINormalFortuneWheelAnimation _003C_003E4__this;

			public int numberOfRotations;

			private int _003CstartIndex_003E5__2;

			private int _003Crotation_003E5__3;

			private int _003Ctick_003E5__4;

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
			public _003CPreviewWheelCoroutine_003Ed__10(int _003C_003E1__state)
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
		private SoundData _specialIntroPartOne;

		[Header("Effects")]
		[SerializeField]
		private RectTransform _fireworkParticleImage;

		[SerializeField]
		private RectTransform _starsEffects;

		private int _pendingItemsToShowCount;

		private int _selectedElementCounter;

		private void OnDisable()
		{
		}

		public override void RefreshElements(List<UIFortuneWheelElement> uiElements)
		{
		}

		public override void StartAnimation()
		{
		}

		protected override void RotateWheelCompleted(int startIndex)
		{
		}

		private void HideEffects()
		{
		}

		[IteratorStateMachine(typeof(_003CPreviewWheelCoroutine_003Ed__10))]
		private IEnumerator PreviewWheelCoroutine(int numberOfRotations)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHandleSelectedElements_003Ed__11))]
		protected override IEnumerator HandleSelectedElements(int elementIndex)
		{
			return null;
		}

		private List<int> GetPreviewIndexes()
		{
			return null;
		}
	}
}
