using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UIRewardPerHourElement : MonoBehaviour
	{
		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private TMP_Text _itemValue;

		public void Construct(Reward reward)
		{
		}
	}
}
