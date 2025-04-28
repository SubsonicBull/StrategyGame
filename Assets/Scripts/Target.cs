using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private float endLine;
    private Vector2 direction = Vector2.left;
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > endLine)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
