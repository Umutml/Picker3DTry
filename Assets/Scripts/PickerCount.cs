using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerCount : MonoBehaviour
{

    static public int ballCount;
    //[SerializeField]private int limitBall = 10; 
    public Player player;
    private int[] limits = { 3, 6, 7};
    private int count = 0;
    private GameManager gamemanage;

    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        player = GameObject.Find("Magnet").GetComponent<Player>();
        gamemanage = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player.weHit)
        {
            StartCoroutine(CheckBall());
            //checkb();
            player.weHit = false;
            
        }
        
        
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballCount++;
            //Debug.Log(ballCount);
           
        }
    }


    IEnumerator CheckBall()
    {
        
        yield return new WaitForSeconds(2f);

        
        
        
        if (ballCount >= gamemanage.limits[0])
        {
            player.isMoving = true;
            ballCount = 0;
            gamemanage.sayi++;
            count++;
            Debug.Log("Limit ve count" + limits[count]);
            
            

            Debug.Log("Ballcount reseted");
            
            // limitball += 10;
        }
        else
        {
            Debug.Log("Ball is not enough!");
            Debug.Log("Limit ve count" + limits[count]);
        }

    }

    


}
