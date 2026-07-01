using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	[CreateAssetMenu(fileName = "AlertData", menuName = "TapHub/Data/Alert Data")]
	public class AlertData : ScriptableObject
	{
		[SerializeField]
		private Sprite _icon;

		[SerializeField]
		private string _message;

		public Sprite Icon => null;

		public string Message => null;
	}
}
