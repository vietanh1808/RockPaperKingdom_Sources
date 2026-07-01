using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class ResourceBuilding : BaseBuilding
	{
		[Header("Sounds")]
		[SerializeField]
		private SoundData _grantSound;

		public ResourceBuildingData ResourceBuildingData { get; private set; }

		public void Construct(ResourceBuildingData buildingData, BuildingRuntime buildingRuntime)
		{
		}

		public void GrantResource()
		{
		}

		private void PlayVisualEffects()
		{
		}

		private void EnqueueResourceDisplay()
		{
		}
	}
}
