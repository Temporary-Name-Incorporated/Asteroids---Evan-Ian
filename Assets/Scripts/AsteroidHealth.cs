using UnityEditor;
using UnityEngine;

    

public class AsteroidHealth : MonoBehaviour
{
    //int health = Random.Range(1, 3);
    float health2;
    SpriteRenderer SpriteRenderer;

    public GameObject Bullet;

    public float score;

    void Start()
    {
        health2 = Random.Range(1, 4);

        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        

        if (GameObject.FindWithTag("Bullet") == true) 
        {
            health2 -= 1;
            
            if (collision.gameObject.CompareTag("Bullet"))
            {
                Destroy(collision.gameObject);
            }
        }

    }


    void Update()
    {
        if (health2 == 3)
        {
            SpriteRenderer.color = Color.magenta;
        }

        if (health2 == 2)
        {
            SpriteRenderer.color = Color.yellow;
        }

        if (health2 == 1)
        {
            SpriteRenderer.color = Color.red;
        }

        if (health2 == 0)
        {
            GameObject.Destroy(gameObject);

            score += 10;
            Debug.Log("Score is now " + score);

        }

    }

}
