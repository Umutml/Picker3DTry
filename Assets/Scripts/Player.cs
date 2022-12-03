using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float axisH;
    private float turnSpeed = 5f;
    private Rigidbody playerRb;
    public bool isMoving = true;
    public bool weHit = false;


    // Start is called before the first frame update
    void Start()
    {
        
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();
    }

    
    private void PlayerControls()
    {
        if (Input.GetButtonDown("Jump") && isMoving)
        {
            isMoving = false;
            playerRb.velocity = Vector3.zero;
        }
        else if (Input.GetButtonDown("Jump") && !isMoving)
        {
            isMoving = true;
        }

        axisH = Input.GetAxis("Horizontal");

        if (isMoving)
        {
            //playerRb.velocity = Vector3.forward * speed;
            transform.Translate(Vector3.forward * speed * Time.deltaTime , Space.World);
        }


        transform.Translate(Vector3.right * turnSpeed * axisH * Time.deltaTime);
    }
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stop"))
        {
            weHit = true;
            playerRb.velocity = Vector3.zero;
            isMoving = false;
            other.gameObject.SetActive(false);
            


        }
    }

    IEnumerator WaitNext()
    {
        yield return new WaitForSeconds(2f);
   
    }

    public void GameOver()
    {
        Debug.Log("Game OVER!");
    }
}
