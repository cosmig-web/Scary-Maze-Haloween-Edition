using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    private Camera cam;
    private Rigidbody2D rb;
    private Vector3 worldPos;
    public string sceneName = "MainScreen";

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        cam = Camera.main;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        worldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void FixedUpdate()
    {
        var targetPos = Vector2.MoveTowards(transform.position, worldPos, speed * Time.fixedDeltaTime);
        rb.MovePosition(targetPos);
    }
}
