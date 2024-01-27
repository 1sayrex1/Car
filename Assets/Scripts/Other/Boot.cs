using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boot : MonoBehaviour
{
    private IEnumerator Start()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        yield return Agava.YandexGames.YandexGamesSdk.Initialize();
#endif
        CounterCoin.Initialization();
        SceneManager.LoadScene(1);
        yield break;
    }
}
    