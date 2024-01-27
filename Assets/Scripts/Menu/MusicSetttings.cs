using UnityEngine;
using UnityEngine.UI;

public class MusicSetttings : MonoBehaviour
{
    [SerializeField] private Slider _volume;

    private void Start()
    {
        _volume.value = PlayerPrefs.GetFloat("music");
        _volume.onValueChanged.AddListener(ChangeVolume);
        ChangeVolume(PlayerPrefs.GetFloat("music"));
    }

    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;   
        PlayerPrefs.SetFloat("music", value);
    }
}
