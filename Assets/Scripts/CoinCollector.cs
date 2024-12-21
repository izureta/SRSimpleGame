using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text coinCounterText;
    private int coinCount = 0;

    private void Start()
    {
        UpdateCoinCounterText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinCount++;
            Destroy(collision.gameObject);
            UpdateCoinCounterText();
        }
    }

    private void UpdateCoinCounterText()
    {
        coinCounterText.text = "Coins: " + coinCount;
    }
}
