using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay
{
	public class UIBuildingDamageStatsItem : MonoBehaviour
	{
		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private TMP_Text _nameText;

		[SerializeField]
		private TMP_Text _damageDealtText;

		[SerializeField]
		private TMP_Text _damageReceivedText;

		public void Construct(BuildingDamageRecord record, int index)
		{
		}

		private static string FormatDamage(float value)
		{
			return null;
		}
	}
}
