using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        sr.enabled = Time.timeScale > 0;
        if(Time.timeScale == 0)
        {
            Destroy(gameObject);
        }
    }
}
