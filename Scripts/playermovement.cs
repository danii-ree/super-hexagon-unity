using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{

    public float moveSpeed = 600f;

    float movement = 0f;
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
	    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
