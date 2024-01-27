using UnityEngine;
using UnityEngine.Events;

public static class CounterCoin
{
    private static int _valueCoins = 0;

    public static int Coins => _valueCoins;

    public static UnityEvent <int> ChangeMoney = new();

    public static void AddCoin(int coin)
    {
        _valueCoins += coin;
        PlayerPrefs.SetInt("ValueCoinGame", _valueCoins);
        ChangeMoney?.Invoke(_valueCoins);
    }

    public static void Initialization()
    {
        _valueCoins = PlayerPrefs.GetInt("ValueCoinGame");
    }
}
