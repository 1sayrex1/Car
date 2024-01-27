using Lean.Localization;
using UnityEngine;
using TMPro;

public class Localization : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown tMP_Dropdown;
    private LeanLocalization _localization;

    private void Awake()
    {
        _localization = GetComponent<LeanLocalization>();

        _localization.SetCurrentLanguage(Agava.YandexGames.YandexGamesSdk.Environment.browser.lang);
#if UNITY_WEBGL && !UNITY_EDITOR
        if (!YandexGameReady.Invoked)
        {
            Agava.YandexGames.YandexGamesSdk.GameReady();
            YandexGameReady.Invoked = true;
        }
# endif
    }

    /* public void TriggerChangeLanguage()
    {
        switch (tMP_Dropdown.value)
        {
            case 1:
                _localization.SetCurrentLanguage("en");
            break;

            case 0:
                _localization.SetCurrentLanguage("ru");
            break;
        }
        Debug.Log(tMP_Dropdown.value);
        PlayerPrefs.SetInt("language", tMP_Dropdown.value);
    }*/
}

public static class YandexGameReady
{
    public static bool Invoked = false;
}