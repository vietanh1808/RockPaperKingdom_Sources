using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class HardModeBackgroundActivator : MonoBehaviour
	{
		[SerializeField]
		private GameObject _hardBackgroundContainer;

		private StageSystem _stageSystem;

		[Inject]
		public void Inject(StageSystem stageSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshBackground()
		{
		}
	}
}
