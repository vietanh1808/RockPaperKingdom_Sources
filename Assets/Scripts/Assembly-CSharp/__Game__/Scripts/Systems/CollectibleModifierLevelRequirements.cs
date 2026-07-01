using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "CollectibleModifierLevelRequirements", menuName = "TapHub/Collectible/Modifier Level Requirements")]
	public class CollectibleModifierLevelRequirements : ScriptableObject
	{
		[SerializeField]
		private int[] _values;

		public int[] Values => null;

		public int GetRequiredLevelIndex(int index)
		{
			return 0;
		}
	}
}
