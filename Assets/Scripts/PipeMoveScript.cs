using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -45f;

    void Update()
    {
        // Move pipe to the left
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy the pipe once it moves past the dead zone (off-screen)
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
