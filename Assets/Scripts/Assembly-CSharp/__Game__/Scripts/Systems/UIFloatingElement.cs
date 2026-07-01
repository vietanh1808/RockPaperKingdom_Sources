using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AssetKits.ParticleImage;
using UnityEngine;
using UnityEngine.Pool;

namespace __Game__.Scripts.Systems
{
	public class UIFloatingElement : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CReleaseNextFrame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIFloatingElement _003C_003E4__this;

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
			public _003CReleaseNextFrame_003Ed__15(int _003C_003E1__state)
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
		private ParticleImage _particleImage;

		[SerializeField]
		private float _defaultStartSize;

		private const int MAX_AMOUNT = 13;

		private const float INTERVAL = 1f / 13f;

		private Reward _reward;

		private Action<Reward> _onTargetReached;

		private RectTransform _targetTransform;

		private ObjectPool<UIFloatingElement> _floatingElementPool;

		private bool _isReleasing;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetPool(ObjectPool<UIFloatingElement> floatingElementPool)
		{
		}

		public void Play(Reward reward, RectTransform source, RectTransform target, Action<Reward> onTargetReached, float startSizeOverride = -1f)
		{
		}

		private void OnReachedTarget()
		{
		}

		private void OnRewardCompleted()
		{
		}

		[IteratorStateMachine(typeof(_003CReleaseNextFrame_003Ed__15))]
		private IEnumerator ReleaseNextFrame()
		{
			return null;
		}
	}
}
