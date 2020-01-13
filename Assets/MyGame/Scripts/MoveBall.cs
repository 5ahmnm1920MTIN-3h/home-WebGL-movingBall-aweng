using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public Transform[] positions;

    public void RandomBallPosition()
    {
        transform.position = positions[Random.Range(0, positions.Length)].position;
    }
}
