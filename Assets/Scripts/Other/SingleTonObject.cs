using UnityEngine;

public class SingleTonObject : MonoBehaviour
{
    
    private static SingleTonObject _instance;

    private void Start()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }
}
