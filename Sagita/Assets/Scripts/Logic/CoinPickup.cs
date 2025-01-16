using UnityEngine;

public class CoinPickup : MonoBehaviour, ICollectible
{
    [SerializeField] int coinValue = 1;

    public void OnPickup(Character character)
    {
        character.coins.AddCoin(coinValue);
    }
}