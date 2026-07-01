namespace __Game__.Scripts.Systems
{
	public class UnitCardNewAlertSystem : BaseCollectibleNewAlertSystem<UnitCardItem, UnitCardItemData>
	{
		public UnitCardNewAlertSystem(UnitCardSystem unitCardSystem)
			: base((BaseCollectibleSystem<UnitCardItem, UnitCardItemData>)null)
		{
		}
	}
}
