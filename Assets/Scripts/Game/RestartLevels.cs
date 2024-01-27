using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevels : MonoBehaviour
{
    [SerializeField] private int _sceneRestart;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(_sceneRestart);
        }
    }
}
