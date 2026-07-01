using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Environment;

namespace __Game__.Scripts.Gameplay
{
	public class WallBounce : MonoBehaviour
	{
		private ScreenEnvironmentBounds _screenEnvironmentBounds;

		[Inject]
		private void Inject(ScreenEnvironmentBounds screenEnvironmentBounds)
		{
		}

		private void Update()
		{
		}
	}
}
