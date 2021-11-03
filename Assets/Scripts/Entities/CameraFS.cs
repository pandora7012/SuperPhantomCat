using UnityEngine;

public class CameraFS : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private Vector3 offset;

    void FixedUpdate()
    {
        Vector2 pos = playerRb.position;
        this.transform.position = new Vector3(pos.x, pos.y, -10) + offset;
    }
}
