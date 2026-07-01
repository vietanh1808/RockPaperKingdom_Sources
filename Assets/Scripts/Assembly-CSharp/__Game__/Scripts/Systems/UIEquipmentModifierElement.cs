using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Systems
{
	public class UIEquipmentModifierElement : MonoBehaviour
	{
		[Header("Icon")]
		[SerializeField]
		private Image _unlockedIcon;

		[SerializeField]
		private Image _lockedIcon;

		[Header("Description")]
		[SerializeField]
		private TMP_FontAsset _unlockedDescriptionFont;

		[SerializeField]
		private TMP_FontAsset _lockedDescriptionFont;

		[SerializeField]
		private Color _unlockedDescriptionColor;

		[SerializeField]
		private Color _lockedDescriptionColor;

		[SerializeField]
		private TMP_Text _description;

		public void Construct(Color color, string description, bool isLock)
		{
		}
	}
}
