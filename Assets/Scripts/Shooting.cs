using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletSpeed = 10f;
    public Transform BulletSpawnPoint;

    AudioSource gunShot;

    private void Start()
    {
        gunShot = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();

            

        }




        
    }

    void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);

        Rigidbody2D BulletRb = Bullet.GetComponent<Rigidbody2D>();
        BulletRb.linearVelocity = transform.up * BulletSpeed;

        gunShot.Play();

    }

    

    
    


}