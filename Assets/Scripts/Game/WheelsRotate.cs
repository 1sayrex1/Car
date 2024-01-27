using UnityEngine;

public class WheelsRotate : MonoBehaviour
{
    [SerializeField] private WheelCollider _targetWheel;

    private void Update()
    {
        Vector3 position;
        Quaternion rotation;
        _targetWheel.GetWorldPose(out position, out rotation);
        transform.rotation = rotation;
        transform.position = position;
    }
}