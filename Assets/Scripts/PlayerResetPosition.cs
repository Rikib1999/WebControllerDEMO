using UnityEngine;

public class PlayerResetPosition : MonoBehaviour
{
    public Vector3 startPosition;

    public void ResetPosition()
    {
        transform.position = startPosition;
    }
}