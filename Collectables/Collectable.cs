using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public GameObject collectManager;

    public int collectValue;

    public GameObject collectedUI;

    // Start is called before the first frame update
    void Start()
    {
        //collectManager = GameObject.Find("CollectableManager");
        
            
    }

 

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "UserPlayer")
        {
            collectManager.GetComponent<CollectableManager>().totalCollectables += collectValue;
            collectedUI.SetActive(false);
            collectedUI.SetActive(true);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
   
}
