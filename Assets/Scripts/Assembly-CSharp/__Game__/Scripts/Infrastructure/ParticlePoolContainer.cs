using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Infrastructure
{
	public class ParticlePoolContainer
	{
		private readonly Dictionary<string, MonoObjectPool<ParticlePoolElement>> _particlePools;

		public void CreatePool(ParticlePoolElement prefab, int initialSize = 5)
		{
		}

		public ParticlePoolElement GetParticle(ParticlePoolElement prefab, Vector3 position)
		{
			return null;
		}

		public void ReturnParticle(ParticlePoolElement element)
		{
		}

		private ParticlePoolElement FactoryMethod(ParticlePoolElement prefab)
		{
			return null;
		}
	}
}
