using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousepos;
    private Camera maincam;
    public GameObject Bullet;
    public Transform BulletTransform;
    public bool canfire = true; // Start with canfire being true, so shooting can begin
    private float timer;
    public float fireTime = 0.5f; // Time between shots

    void Start()
    {
        maincam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        
    }

    void Update()
    {
        // Convert mouse position to world space
        mousepos = maincam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));

        // Calculate the direction from the object to the mouse
        Vector3 rotation = mousepos - transform.position;

        // Calculate the rotation angle to face the mouse
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        // Apply the rotation to the object
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        // Accumulate time for firing cooldown
        if (!canfire)
        {
            timer += Time.deltaTime; // Add the time elapsed since the last frame to the timer
            if (timer >= fireTime) // If enough time has passed
            {
                canfire = true; // Allow firing again
            }
        }

        // Fire when the left mouse button is pressed and shooting is allowed
        if (Input.GetMouseButton(0) && canfire)
        {
            canfire = false; // Disable firing until the cooldown is finished
            timer = 0; // Reset the timer after firing
            Instantiate(Bullet, BulletTransform.position, Quaternion.identity); // Fire the bullet
        }
    }
}