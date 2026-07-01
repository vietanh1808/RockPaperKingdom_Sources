using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_ShopLayout", menuName = "TapHub/Configs/Shop Layout Config")]
	public class ShopLayoutConfig : ScriptableObject
	{
		[SerializeField]
		private GameObject _smallSingleSlot;

		[SerializeField]
		private GameObject _smallPackSlot;

		[SerializeField]
		private GameObject _bigPackSlot;

		[SerializeField]
		private GameObject _chestSlot;

		public GameObject SmallSingleSlot => null;

		public GameObject SmallPackSlot => null;

		public GameObject BigPackSlot => null;

		public GameObject ChestSlot => null;
	}
}
