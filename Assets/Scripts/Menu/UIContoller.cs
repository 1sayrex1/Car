using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIContoller : MonoBehaviour
{
    [SerializeField] private CanvasGroup _settings;

    [SerializeField] private CanvasGroup _question;

    [SerializeField] private Animator _startButtonAnim;

    [SerializeField] private Animator _settingsButtonAnim;

    [SerializeField] private Animator _level1ButtonAnim;

    [SerializeField] private Animator _level2ButtonAnim;

    [SerializeField] private Animator _level3ButtonAnim;

    [SerializeField] private Animator _level4ButtonAnim;

    [SerializeField] private Animator _level5ButtonAnim;

    [SerializeField] private CanvasGroup _erase;

    [SerializeField] private GameObject _closeGame;

    private void Awake()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        if(_closeGame!=null)
            _closeGame.SetActive(false);
#else
        if (_closeGame != null)
            _closeGame.SetActive(true);
#endif
    }

    public void SelectLevel()
    {
        _startButtonAnim.Play("ButtonStartAnimation");
        StartCoroutine(StartButtonAnimation());
    }

    private IEnumerator StartButtonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        while (_startButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonStartAnimation") &&
            _startButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        SceneManager.LoadScene(2);
    }

    public void JoinLevel1()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Agava.YandexGames.InterstitialAd.Show(onOpenCallback:()=>
        {
            AudioListener.pause = true;
        },
        onCloseCallback: _ => {
            _level1ButtonAnim.Play("ButtonLevel1Animation");
            StartCoroutine(Level1ButtonAnimation());
            AudioListener.pause = false;
        }, onErrorCallback: AdditionalCanvasShaderChannels =>
        {
            _level1ButtonAnim.Play("ButtonLevel1Animation");
            StartCoroutine(Level1ButtonAnimation());
            AudioListener.pause = false;
        });
#else
        _level1ButtonAnim.Play("ButtonLevel1Animation");
        StartCoroutine(Level1ButtonAnimation());
#endif
    }

    private IEnumerator Level1ButtonAnimation()
    {
        Debug.Log("1");
        yield return new WaitForSeconds(0.01f);
        while (_level1ButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonLevel1Animation") &&
            _level1ButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        SceneManager.LoadScene(3);
    }

    public void JoinLevel2()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Agava.YandexGames.InterstitialAd.Show(onOpenCallback:()=>
        {
            AudioListener.pause = true;
        },onCloseCallback:_ => {
            _level2ButtonAnim.Play("ButtonLevel2Animation");
            StartCoroutine(Level2ButtonAnimation());
            AudioListener.pause = false;
        }, onErrorCallback: AdditionalCanvasShaderChannels =>
        {
            _level2ButtonAnim.Play("ButtonLevel2Animation");
            StartCoroutine(Level2ButtonAnimation());
            AudioListener.pause = false;
        });
#else
        _level2ButtonAnim.Play("ButtonLevel2Animation");
        StartCoroutine(Level2ButtonAnimation());
#endif
    }

    private IEnumerator Level2ButtonAnimation()
    {
        Debug.Log("2");
        yield return new WaitForSeconds(0.01f);
        while (_level2ButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonLevel2Animation") &&
            _level2ButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        SceneManager.LoadScene(4);
    }

    public void JoinLevel3()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Agava.YandexGames.InterstitialAd.Show(onOpenCallback:()=>
        {
            AudioListener.pause = true;
        },onCloseCallback:_ => {
            _level3ButtonAnim.Play("ButtonLevel3Animation");
            StartCoroutine(Level3ButtonAnimation());
            AudioListener.pause = false;
        }, onErrorCallback: AdditionalCanvasShaderChannels =>
        {
            _level3ButtonAnim.Play("ButtonLevel3Animation");
            StartCoroutine(Level3ButtonAnimation());
            AudioListener.pause = false;
        });
#else
        _level3ButtonAnim.Play("ButtonLevel3Animation");
        StartCoroutine(Level3ButtonAnimation());
#endif
    }

    private IEnumerator Level3ButtonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        while (_level3ButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonLevel3Animation") &&
            _level3ButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        SceneManager.LoadScene(5);
    }

    public void JoinLevel4()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Agava.YandexGames.InterstitialAd.Show(onOpenCallback:()=>
        {
            AudioListener.pause = true;
        },onCloseCallback:_ => {
            _level4ButtonAnim.Play("ButtonLevel4Animation");
            StartCoroutine(Level4ButtonAnimation());
            AudioListener.pause = false;
        }, onErrorCallback: AdditionalCanvasShaderChannels =>
        {
            _level4ButtonAnim.Play("ButtonLevel4Animation");
            StartCoroutine(Level4ButtonAnimation());
            AudioListener.pause = false;
        });
#else
        _level4ButtonAnim.Play("ButtonLevel4Animation");
        StartCoroutine(Level4ButtonAnimation());
#endif
    }

    private IEnumerator Level4ButtonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        while (_level4ButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonLevel4Animation") &&
            _level4ButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        SceneManager.LoadScene(6);
    }

    public void JoinLevel5()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Agava.YandexGames.InterstitialAd.Show(onOpenCallback:()=>
        {
            AudioListener.pause = true;
        },onCloseCallback:_ => {
            _level5ButtonAnim.Play("ButtonLevel5Animation");
             StartCoroutine(Level5ButtonAnimation());
            StartCoroutine(Level5ButtonAnimation());
            AudioListener.pause = false;
        }, onErrorCallback: AdditionalCanvasShaderChannels =>
        {
            _level5ButtonAnim.Play("ButtonLevel5Animation");
            StartCoroutine(Level5ButtonAnimation());
            AudioListener.pause = false;
        });
#else
        _level5ButtonAnim.Play("ButtonLevel5Animation");
        StartCoroutine(Level5ButtonAnimation());
#endif
    }

    private IEnumerator Level5ButtonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        while (_level5ButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonLevel5Animation") &&
            _level5ButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        SceneManager.LoadScene(7);
    }

    public void LeaveLevels()
    {
        SceneManager.LoadScene(1);
    }

    public void LeaveLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenSettings()
    {
        _settingsButtonAnim.Play("ButtonOpenSettingsAnimation");
        StartCoroutine(OpenSettingsButtonAnimation());
    }
    private IEnumerator OpenSettingsButtonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        while (_settingsButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonOpenSettingsAnimation") &&
            _settingsButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }
        _settings.alpha = 1;
        _settings.blocksRaycasts = true;
        _settings.interactable = true;
    }
    public void CloseSettings()
    {
        _settingsButtonAnim.Play("ButtonCloseSettingsAnimation");

        StartCoroutine(CloseSettingsButtonAnimation());
    }

    private IEnumerator CloseSettingsButtonAnimation()
    {
        yield return new WaitForSeconds(0.01f);
        while (_settingsButtonAnim.GetCurrentAnimatorStateInfo(0).IsName("ButtonCloseSettingsAnimation") &&
            _settingsButtonAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1f)
        {
            yield return null;
        }

        _settings.alpha = 0;
        _settings.blocksRaycasts = false;
        _settings.interactable = false;
    }

    public void QuestionOpen()
    {
        _question.alpha = 1;
        _question.blocksRaycasts = true;
        _question.interactable = true;
    }

    public void QuestionClose()
    {
        _question.alpha = 0;
        _question.blocksRaycasts = false;
        _question.interactable = false;
    }

    public void EraseAllProgress()
    {
        PlayerPrefs.DeleteAll();
        int resetMoney = CounterCoin.Coins;
        CounterCoin.AddCoin(-resetMoney);

    }

    public void Close()
    {
        Application.Quit();
    }

}
