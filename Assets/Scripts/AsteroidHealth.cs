using UnityEditor;
using UnityEngine;

    

public class AsteroidHealth : MonoBehaviour
{
    //int health = Random.Range(1, 3);
    float health2;
    SpriteRenderer SpriteRenderer;

    public GameObject Bullet;



    void Start()
    {
        health2 = Random.Range(1, 3);

        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health2 -= 1;

        
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
        }

    }

}
