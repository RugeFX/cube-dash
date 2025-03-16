using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 5.0f;
    public float jump = 5.5f;
    private bool isDead = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;

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

    private void GameOver()
    {
        Debug.Log("Game Over!");
        isDead = true;
        gameManager.GameOver();
    }

    private void Victory()
    {
        Debug.Log("Victory!");
        isDead = true;
        gameManager.Victory();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            GameOver();
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Finish"))
            Victory();
    }
}
