using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_AppReview", menuName = "TapHub/Configs/AppReview")]
	public class AppReviewConfig : ScriptableObject
	{
		[SerializeField]
		private int _stageIndexToShowReview;

		public int StageIndexToShowReview => 0;
	}
}
