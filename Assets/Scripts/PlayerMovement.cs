using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{

    public float speed = 5.0f;
    public float jump = 5.5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Restart1.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = rb.velocity.y;
        float moveHorizontal = rb.velocity.x;

        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = speed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveVertical = jump;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10.0f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5.0f;
        }

        rb.velocity = new Vector3(moveHorizontal, moveVertical, speed);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("Cube");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            RestartGame();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        RestartGame();
    }

    public Button Restart1, Restart2;


}
