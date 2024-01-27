using UnityEngine;

public class CarRotate : MonoBehaviour
{
    [SerializeField] float speedRotate = 1;

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speedRotate * 360);
    }
}
