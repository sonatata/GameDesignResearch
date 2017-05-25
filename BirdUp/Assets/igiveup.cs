using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class igiveup : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rbb;
    private int count;
    private bool ded;
    
 



    private void Start()
    {
        rbb = GetComponent<Rigidbody2D>();

    }



    private void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (0, speed);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("icey"))
        {
            other.gameObject.SetActive(false);
            //count = count + 1;
            //SetCountText();
            //GetComponent<AudioSource>().clip = ay;
            //GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.CompareTag("base"))
        {
            //TODO : you lost if you got here

            //other.gameObject.SetActive(false);
            //count = count + 1;
            //SetCountText();
            //GetComponent<AudioSource>().clip = ay;
            //GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed*2);

            //TODO : you lost if you got here
            
        }


        if(other.gameObject.CompareTag("bomb"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene (2);
            //GetComponent<Rigidbody2D>().SetActive(false);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -2);

            //TODO : you lost if you got here

        }

        if (other.gameObject.CompareTag("win"))
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene (3);
            //Application.LoadLevel(0);
            //GetComponent<Rigidbody2D>().SetActive(false);
            //GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -2);

            //TODO : you lost if you got here

        }
    }
    

}