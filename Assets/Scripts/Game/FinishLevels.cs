using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevels : MonoBehaviour
{
    [SerializeField] private int _sceneNext = 2;
    [SerializeField] private int _valueCoin;

    private void OnTriggerEnter(Collider other)
    {
        CounterCoin.AddCoin(_valueCoin);
        SceneManager.LoadScene(_sceneNext);
    }
}
