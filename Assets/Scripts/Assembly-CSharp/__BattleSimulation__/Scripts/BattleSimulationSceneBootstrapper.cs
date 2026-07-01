using UnityEngine;
using Zenject;

namespace __BattleSimulation__.Scripts
{
	public class BattleSimulationSceneBootstrapper : MonoBehaviour
	{
		private BattleSimulationSystem _battleSimulationSystem;

		[Inject]
		private void Inject(BattleSimulationSystem battleSimulationSystem)
		{
		}

		private void Awake()
		{
		}
	}
}
