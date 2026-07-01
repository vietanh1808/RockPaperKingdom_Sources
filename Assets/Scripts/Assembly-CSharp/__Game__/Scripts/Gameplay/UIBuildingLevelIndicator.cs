using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingLevelIndicator : MonoBehaviour
	{
		private const float POP_OVERSHOOT_SCALE = 1.2f;

		private const float POP_UP_DURATION = 0.2f;

		private const float POP_DOWN_DURATION = 0.15f;

		[SerializeField]
		private List<RectTransform> _levelIndicators;

		private BaseBuilding _building;

		private int _previousLevelIndex;

		public void Initialize(BaseBuilding building)
		{
		}

		private void SetupView()
		{
		}

		private void UpdateLevelIndicators()
		{
		}

		private void PlayPopAnimation(RectTransform indicator)
		{
		}
	}
}
