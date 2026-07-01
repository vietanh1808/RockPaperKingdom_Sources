using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class ExpandInputController : ITickable
	{
		private readonly Camera _camera;

		private readonly GridExpandSystem _gridExpandSystem;

		private readonly LayerMask _slotLayerMask;

		private bool _isEnabled;

		public ExpandInputController(Camera camera, GridExpandSystem gridExpandSystem)
		{
		}

		public void Tick()
		{
		}

		private void OnExpandModeChanged()
		{
		}

		private void HandleInput()
		{
		}
	}
}
