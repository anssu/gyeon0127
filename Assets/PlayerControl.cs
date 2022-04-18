using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRd;
    float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            playerRd.AddForce(0f, speed, 0f);

        }
    }
}