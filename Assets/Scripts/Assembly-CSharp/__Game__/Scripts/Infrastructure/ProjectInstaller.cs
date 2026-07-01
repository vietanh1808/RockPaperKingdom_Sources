using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Infrastructure
{
	public class ProjectInstaller : MonoInstaller
	{
		[Header("Services")]
		[SerializeField]
		private ApplicationLifecycleService _applicationLifecycleService;

		[Header("UI")]
		[SerializeField]
		private UIProjectHolder _uiProjectHolder;

		[SerializeField]
		private UIRewardFloating _uiRewardFloating;

		[SerializeField]
		private UIRewardOverlay _uiRewardOverlay;

		[SerializeField]
		private UIRewardOverlaySpecial _uiRewardOverlaySpecial;

		[SerializeField]
		private UIItemMessage _uiItemMessage;

		[Header("Factory Prefabs")]
		[SerializeField]
		private UIRewardElement _uiRewardElementPrefab;

		[SerializeField]
		private UIEquipmentRewardElement _uiEquipmentRewardPrefab;

		[SerializeField]
		private UIHeroElement _uiHeroPrefab;

		[SerializeField]
		private UIUnitCardRewardElement _uiUnitCardRewardPrefab;

		[SerializeField]
		private UIChestContentView _uiChestContentPrefab;

		public override void InstallBindings()
		{
		}

		private void BindCore()
		{
		}

		private void BindUI()
		{
		}

		private void BindServices()
		{
		}

		private void BindAnalytics()
		{
		}

		private void BindAdsService()
		{
		}

		private void BindSystems()
		{
		}

		private void BindCollectibles()
		{
		}

		private void BindFeatures()
		{
		}

		private void BindSaveLoad()
		{
		}

		private void BindFactories()
		{
		}
	}
}
