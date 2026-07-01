using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class BaseModifier : ScriptableObject
	{
		public abstract void Apply(StaticStatSystem staticStatSystem);

		public abstract string GetDescription();
	}
}
