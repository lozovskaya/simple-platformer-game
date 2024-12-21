using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coinsCollected = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinsCollected++;
            Destroy(collision.gameObject);
        }
    }
}
