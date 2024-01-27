using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using KimicuUtility;
using UnityEngine.SceneManagement;

public class AddCoinForAdvert : MonoBehaviour
{

    [SerializeField] private Button _buttonAddCoin;
    [SerializeField] private GameObject _panelTimer;
    [SerializeField] private TMP_Text _text;
    static public bool advertOn = false;

    private readonly KiCoroutine _routine = new KiCoroutine();

    private void Awake()
    {
        if (PlayerPrefs.GetInt("time", 30) == 30) return;
        _routine.StartRoutine(Timer());
    }


    public void ShowAdvert()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Agava.YandexGames.VideoAd.Show(onOpenCallback: () =>
        {
            advertOn = true;
            AudioListener.pause = true;
        }, onCloseCallback: () => {
            advertOn = false;
            _routine.StartRoutine(Timer());
            CounterCoin.AddCoin(500);
            AudioListener.pause = false;
        }, onErrorCallback: _ =>
        {
            advertOn = false;
            AudioListener.pause = false;
        } );
#else

        _routine.StartRoutine(Timer());
        CounterCoin.AddCoin(500);
#endif

    }
    private IEnumerator Timer()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            _panelTimer.gameObject.SetActive(true);
            _buttonAddCoin.gameObject.SetActive(false);
        }
        int time = PlayerPrefs.GetInt("time", 30);
        while (time > 0)
        {
            _text.text = time.ToString();
            yield return new WaitForSecondsRealtime(1f);
            PlayerPrefs.SetInt("time", --time);
        }
        PlayerPrefs.SetInt("time", 30);
        if (SceneManager.GetActiveScene().buildIndex == 2){
            _panelTimer.gameObject.SetActive(false);
            _buttonAddCoin.gameObject.SetActive(true);
        }
    }
}
