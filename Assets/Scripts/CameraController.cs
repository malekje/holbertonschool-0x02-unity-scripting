using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, 0);

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
