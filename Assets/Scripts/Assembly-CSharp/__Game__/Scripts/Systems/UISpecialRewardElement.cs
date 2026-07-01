using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UISpecialRewardElement : MonoBehaviour
	{
		[SerializeField]
		private Image _rewardIcon;

		[SerializeField]
		private TMP_Text _rewardName;

		public void Construct(Reward reward)
		{
		}
	}
}
