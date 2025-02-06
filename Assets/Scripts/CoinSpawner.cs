using TMPro;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public TMP_Text coinsCollectedText;

    private int coinsCollected = 0;

    private void Start()
    {
        SpawnCoins(10);
    }

    private void SpawnCoins(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject coin = Instantiate(coinPrefab);
            coin.transform.position = new Vector3(Random.Range(-7, 7), 1, Random.Range(-7, 7));
        }
    }

    public void CollectCoin()
    {
        coinsCollected++;
        coinsCollectedText.text = "Coins collected: " + coinsCollected;

        WebControllerManager.SendData("event", "Player has collected a coin");
        WebControllerManager.SendData("coinsCollected", coinsCollected.ToString());
        WebControllerManager.SetContext(new string[] { "coins" });
    }

    public void ResetCoins()
    {
        coinsCollected = 0;
        coinsCollectedText.text = "Coins collected: " + coinsCollected;
        WebControllerManager.SetContext(new string[] { "no_coins" });
    }

    public void SpawnCoinsCommand(WebControllerCommandParameters parameters)
    {
        int count = int.Parse((string)parameters["userInput"]);
        SpawnCoins(count);
    }
}