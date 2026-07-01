using System;
using Zenject;
using __Game__.Scripts.Gameplay.Experience;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay.Listeners
{
	public class ExperienceSpawningListener : IInitializable, IDisposable
	{
		private readonly UnitRepository _unitRepository;

		private readonly ExperienceObjectManager _experienceObjectManager;

		private readonly WaveSystem _waveSystem;

		public ExperienceSpawningListener(UnitRepositoryFactory unitRepositoryFactory, ExperienceObjectManager experienceObjectManager, WaveSystem waveSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnUnitRemoved(BaseUnit unit)
		{
		}
	}
}
