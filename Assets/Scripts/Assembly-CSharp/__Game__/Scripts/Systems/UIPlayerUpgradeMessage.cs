using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerUpgradeMessage : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _upgradeButton;

		[SerializeField]
		private Image _priceIcon;

		[SerializeField]
		private TMP_Text _priceValue;

		[SerializeField]
		private TMP_Text _descriptionValue;

		private PlayerUpgradesSystem _playerUpgradesSystem;

		private PlayerLevelSystem _playerLevelSystem;

		[Inject]
		public void Inject(PlayerUpgradesSystem playerUpgradesSystem, PlayerLevelSystem playerLevelSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ShowMessage(int elementIndex, PlayerUpgradeData playerUpgradeData, Transform messageTarget)
		{
		}

		private void PurchaseUpgrade()
		{
		}

		private Vector2 GetTargetPosition(Transform targetTransform)
		{
			return default(Vector2);
		}
	}
}
