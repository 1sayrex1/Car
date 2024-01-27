using UnityEngine.SceneManagement;
using UnityEngine;

public class LeaveLevels : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}
