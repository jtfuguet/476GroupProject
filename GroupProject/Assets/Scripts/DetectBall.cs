using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            //player has lost, end game / make ball fall through hole
            print("lost game");
        }
    }
} 
