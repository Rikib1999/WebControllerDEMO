using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(transform.up, 100 * Time.deltaTime);
    }
}