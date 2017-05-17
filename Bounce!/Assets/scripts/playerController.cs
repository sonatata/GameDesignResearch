using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float speed;
    public Text countText;

    private Rigidbody rb;
    private int count;
    private bool ded;

    public Text winText;
    public Text loseText;

    public AudioClip ay;
    public AudioClip no;
    public AudioClip yes;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        ded = false;
        SetCountText();
        winText.text = "";
        loseText.text = "";
        GetComponent<AudioSource>().playOnAwake = false;
        
    }
    


    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * speed;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            GetComponent<AudioSource>().clip = ay;
            GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.CompareTag("Spike"))
        {
            other.gameObject.SetActive(true);
            ded = true;
            loseText.text = "GAME OVER";
            GetComponent<AudioSource>().clip = no;
            GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.CompareTag("heaven"))
        {
            other.gameObject.SetActive(false);
            winText.text = "You Win!";
            GetComponent<AudioSource>().clip = yes;
            GetComponent<AudioSource>().Play();
        }
    }

    void SetCountText()
    {
        countText.text = "SCORE " + count.ToString();
    }

}
