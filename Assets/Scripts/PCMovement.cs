using UnityEngine;

public class PCMovement : MonoBehaviour
{

    private Camera maincam;
    private Vector3 mousepos;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        maincam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        Vector2 direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {           
            direction = Vector2.right;
        }

        float dt = Time.deltaTime;
        float speed = 10.0f;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;

        //Rotation of Triangle
        mousepos = maincam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        Vector3 rotation = mousepos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

    }
}
