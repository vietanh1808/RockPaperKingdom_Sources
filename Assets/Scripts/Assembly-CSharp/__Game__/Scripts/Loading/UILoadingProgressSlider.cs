using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Loading
{
	public class UILoadingProgressSlider : MonoBehaviour
	{
		[SerializeField]
		private Slider _slider;

		[SerializeField]
		private TMP_Text _progressText;

		private LoadingProgressController _progressController;

		[Inject]
		public void Construct(LoadingProgressController progressController)
		{
		}

		private void Start()
		{
		}

		private void OnProgressChanged(float progress)
		{
		}

		private void OnProgressCompleted()
		{
		}

		private void UpdateProgress(float progress)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
