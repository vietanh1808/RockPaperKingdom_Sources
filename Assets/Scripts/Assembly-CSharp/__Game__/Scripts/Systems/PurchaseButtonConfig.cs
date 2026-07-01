using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_PurchaseButton", menuName = "TapHub/Configs/Purchase Button")]
	public class PurchaseButtonConfig : ScriptableObject
	{
		[SerializeField]
		private Sprite _defaultBackground;

		[SerializeField]
		private Sprite _freeBackground;

		[SerializeField]
		private Sprite _adsIcon;

		public Sprite DefaultBackground => null;

		public Sprite FreeBackground => null;

		public Sprite AdsIcon => null;
	}
}
