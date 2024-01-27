using UnityEngine;
using Agava.WebUtility;

public class WebBackgroundMusicControll : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        WebApplication.InBackgroundChangeEvent += InBackgrounChanged;
        InBackgrounChanged(true);
    }

    private void InBackgrounChanged(bool inBackground)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        if(AddCoinForAdvert.advertOn == false)
        {
            Debug.Log(WebApplication.InBackground);
            AudioListener.pause = WebApplication.InBackground;
        }
#endif
    }
}