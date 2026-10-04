using UnityEngine;

namespace ProjectSchool2026
{
	public class ArtifactItem : MonoBehaviour
	{
		[SerializeField] private string _artifactName = "Лесной артефакт";

		public string ArtifactName => _artifactName;

		private void OnTriggerEnter2D(Collider2D other)
		{
			// Проверьте игрока, зарегистрируйте сбор и выключите предмет.
		}
	}
}
