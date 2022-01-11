using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ArsenalTabHandler : MonoBehaviour
{

  
    public GameObject pistolTab;

    public GameObject arTab;

    public void pistolView ()
    {
        pistolTab.SetActive(true);
        arTab.SetActive(false);
    }

    public void arView ()
    {
        arTab.SetActive(true);
        pistolTab.SetActive(false);

    }



}
 


