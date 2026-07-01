using System;
using System.Runtime.CompilerServices;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class HeroSelectionAlertSystem : IInitializable, IDisposable
	{
		private readonly HeroConfig _heroConfig;

		private readonly HeroSystem _heroSystem;

		private bool _alertSelection;

		public bool AlertSelection
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnAlertSelectionChanged
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

		public HeroSelectionAlertSystem(HeroConfig heroConfig, HeroSystem heroSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnHeroItemUnlocked(HeroItem heroItem)
		{
		}

		private void UpdateAlertSelectionStatus()
		{
		}

		private void DisableAllAlerts()
		{
		}

		private void UpdateAllAlerts()
		{
		}
	}
}
