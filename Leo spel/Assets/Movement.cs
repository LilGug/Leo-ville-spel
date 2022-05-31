using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        speed.x = Input.GetAxisRaw("Horizontal");
        transform.Translate(speed * 10 * Time.deltaTime , 0);


        print(transform);
    }
}
