using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationArray : MonoBehaviour
{

    public GameObject[] prefabs;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name=="UserPlayer")
        {
            foreach (GameObject prefab in prefabs)
            {
                prefab.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
