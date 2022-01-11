using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBarrier : MonoBehaviour
{


    public GameObject wall;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "UserPlayer")
        {
            wall.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.name == "UserPlayer")
        {
            wall.SetActive(false);
        }
    }
}
