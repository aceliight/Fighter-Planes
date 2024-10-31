using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private int lives = 3;
    private int score = 0;
    public float horizontalInput;
    public float verticalInput;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(Random.Range(0, 9), Random.Range(0, 9), Random.Range(0, 9));
        speed = 5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        if (transform.position.x > 11.5f || transform.position.x <= -11.5f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
        /*
        if (transform.position.y > 8.5f || transform.position.y <= -8.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, 0);
        }
        */
        if (transform.position.y >= 1f)
        {
            transform.position = new Vector3(transform.position.x, 1f, 0);
        }
        else if (transform.position.y <= -4f)
        {
            transform.position = new Vector3(transform.position.x, -4f, 0);
        }
    }

    void Shooting() {
        // if space pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // create bullet
            Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

}
