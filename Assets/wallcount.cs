using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallcount : MonoBehaviour
{

    public int testcount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            testcount++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
