using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject dart;
    [SerializeField] private float power = 10f;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject d = Instantiate(dart, transform.position, Quaternion.Euler(new Vector3(0,0,-90)));
            d.GetComponent<Rigidbody2D>().AddForce((mousepos - transform.position).normalized * power);
        }
    }
}
