using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int[] limits;
    public int sayi = 0;
    public GameObject sectionFirst;
    public GameObject[] spawnPoints;
    public GameObject[] ballLayouts;
    private int gap = 54;
    public GameObject[] Sectionlayouts;
    
    private int randomBall;

    


    // Start is called before the first frame update
    void Start()
    {
        Vector3 section = sectionFirst.transform.position;
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Sectionlayouts[0], new Vector3(section.x, section.y, section.z + 54), Quaternion.identity);
            section.z += 54;
            
            
            
            Vector3 balltemp = new Vector3(spawnPoints[0].transform.position.x, spawnPoints[0].transform.position.y, spawnPoints[0].transform.position.z+ gap);
            Vector3 balltemp1 = new Vector3(spawnPoints[1].transform.position.x, spawnPoints[1].transform.position.y, spawnPoints[1].transform.position.z + gap);
            Vector3 balltemp2 = new Vector3(spawnPoints[2].transform.position.x, spawnPoints[2].transform.position.y, spawnPoints[2].transform.position.z + gap);

            Instantiate(ballLayouts[Random.Range(0, 2)], balltemp, Quaternion.identity);

            Instantiate(ballLayouts[Random.Range(0, 2)], balltemp1, Quaternion.identity);

            Instantiate(ballLayouts[Random.Range(0, 2)], balltemp2, Quaternion.identity);


            gap += 54;
              
        }

    }

   

 
}
