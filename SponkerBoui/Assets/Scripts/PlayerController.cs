using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * 0.01f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (transform.forward * -0.01f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right * 0.01f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (transform.right * -0.01f);
        }

        if (Input.GetKeyDown("space"))
        {
            // turn on the cursor
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce, 0.0f));
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            // turn on the cursor
            transform.localScale = transform.localScale + (transform.up * -0.5f);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            // turn on the cursor
            transform.localScale = transform.localScale + (transform.up * 0.5f);
        }
        /*
        if (Input.GetKey(KeyCode.F))
        {
            transform.localScale = transform.localScale + (transform.localScale * 0.001f);
        }
        if (Input.GetKey(KeyCode.H))
        {
            transform.localScale = transform.localScale + (transform.localScale * -0.001f);
        }
        */
    }
}
