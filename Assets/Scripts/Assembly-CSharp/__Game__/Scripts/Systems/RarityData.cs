using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "RarityData", menuName = "TapHub/Data/Rarity Data")]
	public class RarityData : ScriptableObject
	{
		[SerializeField]
		private string _title;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Sprite _itemFrame;

		[SerializeField]
		private Sprite _collectibleFrame;

		[SerializeField]
		private Sprite _collectibleTitle;

		[SerializeField]
		private Color _fillColor;

		public Color Color => default(Color);

		public Color FillColor => default(Color);

		public string Title => null;

		public Sprite ItemFrame => null;

		public Sprite CollectibleFrame => null;

		public Sprite CollectibleTitle => null;
	}
}
