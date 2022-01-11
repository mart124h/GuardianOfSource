using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arsenal : MonoBehaviour
{
    
    
    
    public GameObject arsenalMenu;
    public bool open;

    //attatchments
    public bool guardianBarrel;
    public bool guardianReceiver;
    public bool guardianBolt;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown("m"))
        {
            open = !open;
        }

        if(open==true)
        {
            Time.timeScale = 1;
            arsenalMenu.SetActive(true);
        }
        
        if(open==false)
        {
            Time.timeScale = 1;
            arsenalMenu.SetActive(false);
        }
    }
}
