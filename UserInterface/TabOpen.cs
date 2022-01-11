using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabOpen : MonoBehaviour
{

    public GameObject[] openUIs;
    public GameObject[] closeUIs;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenUIs()
    {
        foreach (GameObject ui in openUIs)
        {
            ui.SetActive(true);
        }
        
        foreach (GameObject ui in closeUIs)
        {
            ui.SetActive(false);
        }
    }
}
