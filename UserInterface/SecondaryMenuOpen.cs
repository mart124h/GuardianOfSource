using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryMenuOpen : MonoBehaviour
{
    
    public GameObject newMenu;
    public GameObject currentMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void OpenMenu()
    {
            newMenu.SetActive(true);
            
            if(currentMenu)
            {
                currentMenu.SetActive(false);
            }
            else 
            {
                Debug.Log("CurrentMenu is unassigned.");
            }
    }



}
