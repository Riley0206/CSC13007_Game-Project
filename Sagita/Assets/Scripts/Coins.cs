using UnityEngine;

public class Coins : MonoBehaviour
{
    public int CoinCount;

    [SerializeField] TMPro.TextMeshProUGUI coinText;

    private void Awake()
    {
        coinText.text = "Gold: 0";
    }

    public void AddCoin(int amount)
    {
        CoinCount += amount;
        coinText.text = "Gold: " + CoinCount.ToString();
    }
}
