using UnityEngine;

namespace ProjectSchool2026
{
	public class CameraFollow : MonoBehaviour
	{
		[SerializeField] private Transform _target;
		[SerializeField][Min(0f)] private float _smoothSpeed = 8f;
		[SerializeField] private Vector3 _offset = new Vector3(0f, 0f, -10f);

		private void LateUpdate()
		{
			// Обновите положение камеры относительно игрока.
		}
	}
}
