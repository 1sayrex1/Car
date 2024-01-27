using UnityEngine.SceneManagement;
using UnityEngine;

public class LeaveLevel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }
    }
}
