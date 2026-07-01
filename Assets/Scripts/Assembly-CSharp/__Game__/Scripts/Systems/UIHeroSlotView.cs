using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIHeroSlotView : MonoBehaviour
	{
		[SerializeField]
		private List<UIHeroSlot> _heroSlots;

		private HeroSystem _heroSystem;

		public event Action OnInitialized
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
		public void Inject(HeroSystem heroSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
