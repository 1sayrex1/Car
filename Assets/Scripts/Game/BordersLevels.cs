using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardsLevels : MonoBehaviour
{
    [SerializeField] public GameObject _car;

    [SerializeField] private int _sceneRestart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.parent.TryGetComponent(out PlayerMovement car))
        {
            SceneManager.LoadScene(_sceneRestart);
        }
        else
            Destroy(other.gameObject);
    }
}
