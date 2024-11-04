using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDogMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private const float SpeedUnitsPerSecond = 3f;
    private bool _movementInProgress;
    private Vector3 _targetPosition;
    private float _startTime;
    private Vector3 _startPosition;

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

        _startPosition = this.gameObject.transform.position;
        var newPosition = _startPosition;

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            _movementInProgress = true;
            _startTime = Time.time;
            _targetPosition = UpdateXPosition(-1, _startPosition);
        }

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            _movementInProgress = true;
            _startTime = Time.time;
            _targetPosition = UpdateXPosition(1, _startPosition);
        }

        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
        {
            _movementInProgress = true;
            _startTime = Time.time;
            _targetPosition = UpdateZPosition(1, _startPosition);
        }

        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
        {
            _movementInProgress = true;
            _startTime = Time.time;
            _targetPosition = UpdateZPosition(-1, _startPosition);
        }
    }

    private Vector3 UpdateXPosition(int delta, Vector3 activePosition)
    {
        return new Vector3(activePosition.x + delta, activePosition.y, activePosition.z);
    }

    private Vector3 UpdateZPosition(int delta, Vector3 activePosition)
    {
        return new Vector3(activePosition.x, activePosition.y, activePosition.z + delta);
    }
}
