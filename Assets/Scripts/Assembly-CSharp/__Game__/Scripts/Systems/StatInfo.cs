using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatInfo", menuName = "TapHub/Stats/Stats Info")]
	public class StatInfo : ScriptableObject
	{
		[SerializeField]
		private string _title;

		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private float power;

		public string Title => null;

		public Sprite Icon => null;

		public float Power => 0f;
	}
}
