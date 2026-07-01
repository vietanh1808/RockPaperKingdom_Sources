using System;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingStatChangeItem : MonoBehaviour, IPoolElement
	{
		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private Vector3 _animationOffset;

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}

		public void SetStatChange(string text)
		{
		}

		public void RunAnimation(Vector3 localPosition, Action onAnimationFinished)
		{
		}
	}
}
