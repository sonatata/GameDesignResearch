using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerController : MonoBehaviour
{

    //public float speed;
    public int count;

    private Rigidbody rb;
    private AnchoredJoint2D jnt;
    public GameObject myPrefab;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jnt = GetComponent<AnchoredJoint2D>();

        //jnt.transform.
        count = 0;
        //GetComponent<AudioSource>().playOnAwake = false;

    }



    private void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        
        //rb.AddForce();

        if (Input.GetKeyDown(KeyCode.Space))
        //if (Input.GetMouseButtonDown())
        {
            Destroy(GetComponent<AnchoredJoint2D>());


            //GameObject go = (GameObject)Instantiate(myPrefab);

            //(GameObject)Instantiate(myPrefab);


            //reactionTorque = breakTorque * 5;
            //GetComponent<Rigidbody>().velocity = Vector3.up * speed;
            //GetComponent<Rigidbody>().velocity = Vector3.up * speed;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("base"))
        {
            //other.gameObject.SetActive(true);
            count = count + 1;
        }

    }
}
