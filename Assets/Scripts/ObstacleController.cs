using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.position += new Vector3(0, 0, 200);
    }
}
