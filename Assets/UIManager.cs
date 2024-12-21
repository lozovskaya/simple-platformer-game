using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public CoinCollector player;

    void Update()
    {
        coinText.text = "Coins: " + player.coinsCollected;
    }
}
