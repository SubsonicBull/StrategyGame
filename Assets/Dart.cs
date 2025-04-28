using UnityEngine;

public class Dart : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Rad2Deg * (Mathf.Asin(rb.linearVelocity.normalized.y/rb.linearVelocity.normalized.x))));
    }
}
