using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 speed;
    Rigidbody2D kuk;
    [SerializeField] int movementSpeed;
    [SerializeField] int jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        kuk = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed.x = Input.GetAxisRaw("Horizontal");
        // transform.Translate(speed * movementSpeed * Time.deltaTime , 0);
        kuk.AddForce(Vector2.right * speed.x * movementSpeed);
        if (Input.GetButtonDown("Jump")) {
            Jump();
        }
    }

    bool isGrounded() {
        float extraHeight = 5f;
        

        return false;
    }

    void Jump() {
        print("jump");
        kuk.velocity = new Vector2(kuk.velocity.x, jumpHeight);
    }
}
