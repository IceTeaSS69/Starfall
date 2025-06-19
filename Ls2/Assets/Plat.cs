using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class Plat : MonoBehaviour
{
    public GameObject player;
    public Text Scoreline;

    private float DelCircles = 0;
    private void Update()
    {
        if (player == null)
        {
            // Показываем текст
            Scoreline.text = ($"Your Record/{DelCircles}");
            Time.timeScale = 0;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            DelCircles++;
        }
        if (collision.gameObject.tag == "Platform")
        {
            Destroy(collision.gameObject);
            DelCircles++;
        }


    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Coin")
        {
            Destroy(collider.gameObject);
            DelCircles++;
        }
        if (collider.gameObject.tag == "Platform")
        {
            Destroy(collider.gameObject);
            DelCircles++;
        }

    }
}
