namespace __Game__.Scripts.Gameplay
{
	public class BuildingDamageRecord
	{
		public BaseBuildingData BuildingData { get; }

		public float TotalDamageDealt { get; set; }

		public float TotalDamageReceived { get; set; }

		public BuildingDamageRecord(BaseBuildingData buildingData)
		{
		}
	}
}
