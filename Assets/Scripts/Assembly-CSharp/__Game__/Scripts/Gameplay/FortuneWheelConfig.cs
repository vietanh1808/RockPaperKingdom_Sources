using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Config_FortuneWheel", menuName = "TapHub/Ability/Fortune Wheel Config")]
	public class FortuneWheelConfig : ScriptableObject
	{
		[SerializeField]
		private List<float> _selectedAmountWeights;

		public int GetSelectedAmount()
		{
			return 0;
		}
	}
}
