using TMPro;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleModifierElement : MonoBehaviour
	{
		[Header("Unlocked")]
		[SerializeField]
		private GameObject _unlockedContainer;

		[SerializeField]
		private TMP_Text _unlockedValue;

		[Header("Locked")]
		[SerializeField]
		private GameObject _lockedContainer;

		[SerializeField]
		private TMP_Text _lockedValue;

		[SerializeField]
		private TMP_Text _requiredValue;

		public void Construct(string description, string requirement, bool isLock)
		{
		}

		public void Unlock()
		{
		}
	}
}
