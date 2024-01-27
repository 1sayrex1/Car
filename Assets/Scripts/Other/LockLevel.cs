using UnityEngine;

public class LockLevel : MonoBehaviour
{
    [SerializeField] private int _cost;
    [SerializeField] private string _level;
    [SerializeField] private WarningPanel _warningPanel;

    private void Awake()
    {
        if (PlayerPrefs.GetInt($"{_level}_Opened") == 1)
        {
            Destroy(gameObject);
        }
    }

    public void TryBuy()
    {
        if (_cost <= CounterCoin.Coins)
        {
            CounterCoin.AddCoin(-_cost);
            PlayerPrefs.SetInt($"{_level}_Opened", 1);
            Destroy(gameObject);
        }
        else
        {
            _warningPanel.StartCoroutine();
        }
    }
}
