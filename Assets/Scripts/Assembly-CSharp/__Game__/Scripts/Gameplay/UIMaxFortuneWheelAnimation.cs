using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class UIMaxFortuneWheelAnimation : UIBaseFortuneWheelAnimation
	{
		[CompilerGenerated]
		private sealed class _003CHandleSelectedElements_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIMaxFortuneWheelAnimation _003C_003E4__this;

			public int elementIndex;

			private int _003CselectedElementCounter_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CHandleSelectedElements_003Ed__10(int _003C_003E1__state)
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
		private sealed class _003CPreviewFireworkCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIMaxFortuneWheelAnimation _003C_003E4__this;

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
			public _003CPreviewFireworkCoroutine_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CPreviewWheelCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIMaxFortuneWheelAnimation _003C_003E4__this;

			private int _003Ccount_003E5__2;

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
			public _003CPreviewWheelCoroutine_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CShowAllFocusMarks_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIMaxFortuneWheelAnimation _003C_003E4__this;

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
			public _003CShowAllFocusMarks_003Ed__15(int _003C_003E1__state)
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
		private sealed class _003CShowFireworkCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIMaxFortuneWheelAnimation _003C_003E4__this;

			private Dictionary<int, List<int>>.ValueCollection.Enumerator _003C_003E7__wrap1;

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
			public _003CShowFireworkCoroutine_003Ed__13(int _003C_003E1__state)
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
		private SoundData _specialIntroPartOne;

		[SerializeField]
		private SoundData _specialIntroPartTwo;

		[SerializeField]
		private SoundData _specialIntroPartThree;

		[Header("Effects")]
		[SerializeField]
		private RectTransform _fullscreenConfetti;

		[SerializeField]
		private RectTransform _starsEffects;

		[SerializeField]
		private List<RectTransform> _fireworkParticleImages;

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

		[IteratorStateMachine(typeof(_003CHandleSelectedElements_003Ed__10))]
		protected override IEnumerator HandleSelectedElements(int elementIndex)
		{
			return null;
		}

		private void HideEffects()
		{
		}

		[IteratorStateMachine(typeof(_003CPreviewFireworkCoroutine_003Ed__12))]
		private IEnumerator PreviewFireworkCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowFireworkCoroutine_003Ed__13))]
		private IEnumerator ShowFireworkCoroutine()
		{
			return null;
		}

		private void ShowFireworkParticleByIndex(int index)
		{
		}

		[IteratorStateMachine(typeof(_003CShowAllFocusMarks_003Ed__15))]
		private IEnumerator ShowAllFocusMarks()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPreviewWheelCoroutine_003Ed__16))]
		private IEnumerator PreviewWheelCoroutine()
		{
			return null;
		}
	}
}
