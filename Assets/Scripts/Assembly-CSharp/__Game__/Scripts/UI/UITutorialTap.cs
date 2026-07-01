using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.UI
{
	public class UITutorialTap : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSetupCanvas_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UITutorialTap _003C_003E4__this;

			public Transform targetTransform;

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
			public _003CSetupCanvas_003Ed__18(int _003C_003E1__state)
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
		private RectTransform _markContainer;

		[SerializeField]
		private Image _markImage;

		[SerializeField]
		private Sprite _markSprite;

		[Header("Settings")]
		[SerializeField]
		private float _moveRange;

		[SerializeField]
		private float _moveDuration;

		private const float DEFAULT_OFFSET = 50f;

		private Transform _targetTransform;

		private float _distanceOffset;

		private Canvas _currentElementCanvas;

		private GraphicRaycaster _currentGraphicRaycaster;

		private Tween _markTween;

		private void Update()
		{
		}

		public UITutorialTap Show(Transform targetTransform, float angle = 0f)
		{
			return null;
		}

		public UITutorialTap SetSprite(Sprite sprite)
		{
			return null;
		}

		public UITutorialTap SetDistanceOffset(float offset)
		{
			return null;
		}

		public void Hide()
		{
		}

		private void ClearPreviousElement()
		{
		}

		private void SetupCurrentElement(Transform targetTransform)
		{
		}

		[IteratorStateMachine(typeof(_003CSetupCanvas_003Ed__18))]
		private IEnumerator SetupCanvas(Transform targetTransform)
		{
			return null;
		}

		private void AnimateMark()
		{
		}

		private void RestartMarkTween()
		{
		}
	}
}
