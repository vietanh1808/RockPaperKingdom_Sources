using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.UI
{
	[RequireComponent(typeof(Toggle))]
	public class UIToggleSound : MonoBehaviour
	{
		[SerializeField]
		private SoundData _toggleSound;

		private Toggle _toggle;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnToggleValueChanged(bool isOn)
		{
		}
	}
}
