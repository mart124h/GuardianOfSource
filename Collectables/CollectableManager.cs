using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectableManager : MonoBehaviour
{
   
   public int totalCollectables;

   public int maxCollectables = 100;

   public Text collectNotifyCounter;

    // Start is called before the first frame update
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
        collectNotifyCounter.GetComponent<Text>().text = "" + totalCollectables + " / " + maxCollectables;
    }
}
