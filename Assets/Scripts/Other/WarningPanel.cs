using System.Collections;
using UnityEngine;

public class WarningPanel : MonoBehaviour
{
    [SerializeField] private CanvasGroup _error;
    private IEnumerator _enumerator;
    IEnumerator Wait()
    {
        float time = 0;
        while (time <= 1)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            time += Time.deltaTime;
            _error.alpha = time;
        }
        _error.blocksRaycasts = true;
        _error.interactable = true;
        yield return new WaitForSeconds(1);

        while (time >= 0)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            time -= Time.deltaTime;
            _error.alpha = time;
        }
        _error.blocksRaycasts = false;
        _error.interactable = false;
        _enumerator = null;
    }
    public void StartCoroutine()
    {
        if (_enumerator != null)
        {
            return;
        }
        _error.alpha = 0;
        _error.blocksRaycasts = false;
        _error.interactable = false;
        _enumerator = Wait();
        StartCoroutine(_enumerator);
    }
}
