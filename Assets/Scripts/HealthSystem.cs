using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{

    int playerHealth = 3;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            playerHealth -= 1;

            Debug.Log("Health is now " + playerHealth);
        }

        if (playerHealth <= 0)
        {
            SceneManager.LoadSceneAsync("End Screen");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
