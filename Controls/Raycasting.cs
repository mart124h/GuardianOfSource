using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Physics;

public class Raycasting : MonoBehaviour
{

    public float range = 1000f;
    public GameObject lastHit;
    public GameManager gameManager;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void ActivateNotice ()
    {
           gameManager.gameCursor.SetActive(false);
           gameManager.activateIcon.SetActive(true);
    }


    void GUIReset ()
    {
           gameManager.gameCursor.SetActive(true);
           gameManager.activateIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, this.transform.forward);

       

        
        if(Physics.Raycast(ray, out hit, range))
        {
            lastHit = hit.transform.gameObject;

            if(lastHit.gameObject.tag=="activatable" && lastHit.gameObject.name=="CryoDoor" )
            {
                gameManager.gameCursor.SetActive(false);
                gameManager.shootIcon.SetActive(true);

                 if(Input.GetMouseButton(0))
                    {
                        lastHit.GetComponent<CryoChamberDoor>().selected=true;
                    }
            }

           

           if(lastHit.gameObject.tag=="activatable" && lastHit.gameObject.name=="RemoteController")
           {
               
               ActivateNotice();

               
                if(Input.GetKeyDown("e"))
                {
                    if(lastHit.GetComponent<DoorRemote>().activated==false)
                    {
                        lastHit.GetComponent<DoorRemote>().activated=true;
                    }
                    else 
                    {
                        lastHit.GetComponent<DoorRemote>().activated=false;
                    }
                }
           }

           if(lastHit.gameObject.tag=="activatable" && lastHit.gameObject.name=="StatueRemoter")
           {
               ActivateNotice();

               if(Input.GetKeyDown("e"))
               {
                    lastHit.gameObject.GetComponent<GuardianStatue>().GuardianTransform();    
               }
           }

           if(lastHit.gameObject.tag!="activatable")
            {
              GUIReset();
            }

        }

    }
}
