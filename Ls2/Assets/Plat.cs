using UnityEngine;

public class Plat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Platform")
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Coin")
        {
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "Platform")
        {
            Destroy(collider.gameObject);
        }
    }
}
