using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playa: MonoBehaviour
{

    public float speed;
    public Text countText;

    private Rigidbody rb;
    private int count;
    private bool ded;

    public Text winText;
    public Text loseText;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }



    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * speed;
        }

    }
    

}
