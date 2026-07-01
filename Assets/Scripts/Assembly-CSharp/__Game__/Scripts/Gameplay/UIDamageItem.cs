using System;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class UIDamageItem : SerializedMonoBehaviour, IPoolElement
	{
		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private Color _defaultTypeColor;

		[SerializeField]
		private Color _enemyTypeColor;

		[SerializeField]
		private Color _fireTypeColor;

		[SerializeField]
		private Color _reflectionTypeColor;

		private float _scaleValue;

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}

		public UIDamageItem SetDamage(Damage damage)
		{
			return null;
		}

		public void RunAnimation(Action onAnimationFinished)
		{
		}

		private Color GetColor(DamageType damageType)
		{
			return default(Color);
		}
	}
}
