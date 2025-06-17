using UnityEngine;
using UnityEngine.UI;


public class WalkRem : MonoBehaviour
{

    [SerializeField]
 
    public int Coins = 0;
    public float WalkL = 0.5f;
    public int Health = 100;
    public Text Record;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Awake()
    {

        Record.text = ($"{Health}");



    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            Coins++;
            
            Health--;
        }
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Coin")
        {          
            Destroy(collider.gameObject);
            Coins++;
            
            Health--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = gameObject.transform.position - new Vector3(WalkL, 0,0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(WalkL, 0, 0);
        }


    }
    public void HealthAndStamina()
    {
        if(Health >= 0)
        {
            Destroy(gameObject);
            Record.text = ($"{Coins}");
        }
    }
}
