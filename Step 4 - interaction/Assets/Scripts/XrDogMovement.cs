using UnityEngine;

namespace Assets.Scripts
{
    public class XrDogMovement : MonoBehaviour
    {
        private const float SpeedUnitsPerSecond = 1f;

        private bool _movementInProgress;
        private Vector3 _targetPosition;
        private float _startTime;
        private Vector3 _startPosition;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (_movementInProgress)
            {
                var elapsedTime = Time.time - _startTime;
                var distanceCovered = elapsedTime * SpeedUnitsPerSecond;
                gameObject.transform.position = Vector3.Lerp(_startPosition, _targetPosition, distanceCovered);

                if (_targetPosition == gameObject.transform.position)
                {
                    _movementInProgress = false;
                }
                else
                {
                    return;
                }
            }

            if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
            {
                _movementInProgress = true;
                _startTime = Time.time;

                _startPosition = gameObject.transform.position;
                _targetPosition = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
            }

            if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {
                _movementInProgress = true;
                _startTime = Time.time;

                _startPosition = gameObject.transform.position;
                _targetPosition = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y, gameObject.transform.position.z);
            }
        }
    }
}