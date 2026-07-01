using UnityEngine;
using Zenject;

namespace __Simulation__.SimulationModules
{
	public abstract class BaseSimulationModuleHolder : ScriptableObject
	{
		public abstract ISimulationModule GetModule(DiContainer container);
	}
	public abstract class BaseSimulationModuleHolder<T> : BaseSimulationModuleHolder where T : ISimulationModule
	{
		public override ISimulationModule GetModule(DiContainer container)
		{
			return null;
		}
	}
}
