using UnityEngine;

public class Rotator : MonoBehaviour
{
    float rotation = 45f;

    void Update()
    {
        transform.Rotate (rotation * Time.deltaTime, 0, 0);
    }
}
