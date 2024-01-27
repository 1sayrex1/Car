using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private float _sensetive = 1;
    [SerializeField] private CinemachineVirtualCamera _camera;

    private Vector2 _delta;
    private Vector2 _lastMousePosition;
    private CinemachineComposer _composer;
    private float _time = 1;

    private void Start()
    {
        _composer = _camera.GetCinemachineComponent<CinemachineComposer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            _delta = Input.mousePosition - (Vector3)_lastMousePosition;
            _lastMousePosition = Input.mousePosition;
            _time = 1;
        }

        _composer.m_ScreenX += -Time.deltaTime * _sensetive * _delta.x;
        _composer.m_ScreenY += Time.deltaTime * _sensetive * _delta.y;

        _time -= Time.deltaTime;
        if(_time <= 0)
        {
            _composer.m_ScreenX = 0.5f;
            _composer.m_ScreenY = 0.5f;
            _time = 1;
        }
    }
}
