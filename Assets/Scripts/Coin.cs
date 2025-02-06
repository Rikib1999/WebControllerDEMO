using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType(typeof(CoinSpawner)).GetComponent<CoinSpawner>().CollectCoin();
            Destroy(gameObject);
        }
    }
}