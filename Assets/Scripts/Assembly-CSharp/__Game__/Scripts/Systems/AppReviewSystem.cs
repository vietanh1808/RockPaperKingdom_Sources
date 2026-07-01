namespace __Game__.Scripts.Systems
{
	public class AppReviewSystem
	{
		private readonly StageSystem _stageSystem;

		private readonly AppReviewConfig _config;

		private bool _hasPendingReview;

		public bool IsReviewShown { get; private set; }

		public AppReviewSystem(StageSystem stageSystem, AppReviewConfig config)
		{
		}

		public void Initialize()
		{
		}

		public void LoadData(bool isReviewShown)
		{
		}

		public bool HasPendingReview()
		{
			return false;
		}

		public void MarkReviewShown()
		{
		}

		private void OnLastAvailableIndexChanged()
		{
		}
	}
}
