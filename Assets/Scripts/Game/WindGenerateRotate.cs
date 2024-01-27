using UnityEngine;

public class WindGenerateRotate : MonoBehaviour
{
    [SerializeField] float speedRotate = 10;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speedRotate * 360);
    }
}
