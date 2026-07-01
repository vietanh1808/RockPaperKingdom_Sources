using UnityEngine;

namespace __Game__.Scripts.Infrastructure
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticlePoolElement : MonoBehaviour, IPoolElement
	{
		[SerializeField]
		private string _guid;

		private ParticleSystem _particleSystem;

		private ParticlePoolContainer _particlePoolContainer;

		public string Guid => null;

		private void Awake()
		{
		}

		public void Init(ParticlePoolContainer particlePoolContainer)
		{
		}

		public void Play(Vector3 position)
		{
		}

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}

		public void Release()
		{
		}

		private void OnParticleSystemStopped()
		{
		}
	}
}
