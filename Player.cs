using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Fields
    private float speed;
    private int lives = 3;
    private int score = 0;
    private float horizontalInput;
    private float verticalInput;
    public float maxYPositionup = -0.5f;
    public float maxYPositiondown = -4f;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        Vector3 position = transform.position;

        if (transform.position.x > 11.5f || transform.position.x <= -11.5f)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }

        if (position.y > maxYPositionup)
        {
            position.y = maxYPositionup;
        }
        if (position.y < maxYPositiondown)
        {
            position.y = maxYPositiondown;
        }

        transform.position = position;
    }

    void Shooting()
    {
        // If I press SPACE, create a bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
