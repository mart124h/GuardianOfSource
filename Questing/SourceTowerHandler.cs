using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SourceTowerHandler : MonoBehaviour
{


    public int sourceTowers;

    public int sourceTowersActivated;

    public bool activation;

    public float duration;

    public Text sourceTowerText;

    public GameObject activationUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(activation==true)
        Activation();

        if(sourceTowersActivated<sourceTowers)
        {
            sourceTowerText.GetComponent<Text>().text = "" + sourceTowersActivated + "/" + sourceTowers;
        }
         if(sourceTowersActivated>=sourceTowers)
        {
            sourceTowerText.GetComponent<Text>().text = "✓";
            sourceTowersActivated = sourceTowers;
        }

        
    }

    public void Activation()
    {
    
        activation = false;
        sourceTowersActivated++;
        activationUI.SetActive(true);
        StartCoroutine("CountDown");
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(duration);
        activationUI.SetActive(false);
    }
}
