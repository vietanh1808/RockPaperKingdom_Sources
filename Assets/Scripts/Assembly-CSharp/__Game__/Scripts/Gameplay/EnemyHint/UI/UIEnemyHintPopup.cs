using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.EnemyHint.UI
{
	public class UIEnemyHintPopup : UIBasePopup
	{
		[SerializeField]
		private Image _unitIcon;

		[SerializeField]
		private TMP_Text _unitTitle;

		[SerializeField]
		private TMP_Text _hintDescription;

		public void Show(EnemyHintEntry entry)
		{
		}
	}
}
