using UnityEngine;

namespace ProjectSchool2026
{
	public class ArtifactItem : MonoBehaviour
	{
		[SerializeField] private string _artifactName = "Лесной артефакт";

		public string ArtifactName => _artifactName;

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.attachedRigidbody == null)
			{
				return;
			}

			// Коллайдер игрока может находиться на дочернем объекте.
			if (!other.attachedRigidbody.TryGetComponent<PlayerMovement>(out _))
			{
				return;
			}

			var explorationManager = ExplorationManager.Instance;
			if (explorationManager == null)
			{
				return;
			}

			if (explorationManager.CollectArtifact(this))
			{
				gameObject.SetActive(value: false);
			}
		}
	}
}
