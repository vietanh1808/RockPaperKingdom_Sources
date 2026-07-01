namespace __Game__.Scripts.Services
{
	public class LocalNotificationService
	{
		private const string CHANNEL_ID = "daily_rewards";

		private const string CHANNEL_NAME = "Daily Rewards";

		private const string CHANNEL_DESCRIPTION = "Daily reward reminders";

		private const string DAILY_REWARD_TITLE = "Your daily reward is ready!";

		private const string DAILY_REWARD_TEXT = "Come back and claim your daily reward!";

		private readonly ApplicationLifecycleService _applicationLifecycleService;

		private int _dailyRewardNotificationId;

		public LocalNotificationService(ApplicationLifecycleService applicationLifecycleService)
		{
		}

		public void Initialize()
		{
		}

		public void ScheduleDailyRewardNotification()
		{
		}

		public void ScheduleTestNotification()
		{
		}

		private void HandleFocusChanged(bool hasFocus)
		{
		}

		private void RegisterChannel()
		{
		}

		private void RequestPermission()
		{
		}

		private void CancelDailyRewardNotification()
		{
		}
	}
}
