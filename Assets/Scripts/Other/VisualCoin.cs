using UnityEngine;
using TMPro;

public class VisualCoin : MonoBehaviour
{
    [SerializeField] private TMP_Text _visualCoin;

    private void Awake()
    {
        OnChangeCoin(CounterCoin.Coins);
        CounterCoin.ChangeMoney.AddListener(OnChangeCoin);
    }

    private void OnChangeCoin(int valuecoin)
    {
        _visualCoin.text = valuecoin.ToString();
    }
}

