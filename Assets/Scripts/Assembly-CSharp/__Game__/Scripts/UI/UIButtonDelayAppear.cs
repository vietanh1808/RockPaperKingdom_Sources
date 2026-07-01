using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UIButtonDelayAppear : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private RectTransform _animationTarget;

		[SerializeField]
		private float _delayDuration;

		[SerializeField]
		private float _delayedAppearDuration;

		private TweenerCore<Vector3, Vector3, VectorOptions> _tweener;

		private RectTransform _rectTransform;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
