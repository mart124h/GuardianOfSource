using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceTowerActivate : MonoBehaviour
{


    public GameObject activateUi;
    public GameObject activationGroup;
    public GameObject sourceHandler;
    public GameObject wayPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider col)
    {
        if(col.gameObject.name=="UserPlayer")
        {
            activateUi.SetActive(true);

            if(Input.GetKeyDown("e"))
            {
                activateUi.SetActive(false);
                sourceHandler.GetComponent<SourceTowerHandler>().activation = true;
                activationGroup.SetActive(true);
                wayPoint.SetActive(false);
                Destroy(this.gameObject);
            }
        }
    }

     public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.name=="UserPlayer")
        {
            activateUi.SetActive(false);

        }
    }
}
