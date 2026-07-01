using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIHeroUnitCardNewAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private UnitCardSystem _unitCardSystem;

		private HeroItem _heroItem;

		private readonly List<UnitCardItem> _trackedCards;

		public event Action<bool> OnAlertVisibilityChanged
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
		private void Inject(UnitCardSystem unitCardSystem)
		{
		}

		public void Init(HeroItem heroItem)
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void SubscribeToCards()
		{
		}

		private void UnsubscribeFromCards()
		{
		}

		private void OnIsNewChanged(bool isNew)
		{
		}

		private void RefreshAlert()
		{
		}
	}
}
