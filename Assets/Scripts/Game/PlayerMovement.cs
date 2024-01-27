using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _maxMotorTorque = 10;
    [SerializeField] private float _maxSteeringAngle = 40;
    [SerializeField] private WheelCollider _frontLeftWheel;
    [SerializeField] private WheelCollider _frontRightWheel;
    [SerializeField] private WheelCollider _rearLeftWheel;
    [SerializeField] private WheelCollider _rearRightWheel;

    private float _cessationMovement;
    private float _motorInput;
    private float _steeringInput;

    private void Update()       
    {
        _motorInput = Input.GetAxis("Vertical") * _maxMotorTorque;
        _steeringInput = Input.GetAxis("Horizontal") * _maxSteeringAngle;

        if (Input.GetKey(KeyCode.Space))
        {
            _cessationMovement = 1;
        }
        else
            _cessationMovement = 0;

    }
    private void FixedUpdate()
    {
        _frontLeftWheel.steerAngle = _steeringInput;
        _frontRightWheel.steerAngle = _steeringInput;
        _rearLeftWheel.motorTorque = _motorInput;
        _rearRightWheel.motorTorque = _motorInput;

        if (_cessationMovement == 1)
        {
            _rearLeftWheel.motorTorque = 0;
            _rearRightWheel.motorTorque = 0;
        }
    }
}
