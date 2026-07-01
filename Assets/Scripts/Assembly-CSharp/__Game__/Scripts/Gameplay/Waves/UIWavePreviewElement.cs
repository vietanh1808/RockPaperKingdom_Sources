using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class UIWavePreviewElement : MonoBehaviour
	{
		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _label;

		public void Setup(Sprite icon, string label)
		{
		}

		public void Hide()
		{
		}
	}
}
