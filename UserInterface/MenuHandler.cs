using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuHandler : MonoBehaviour
{

    public bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject[] allUIMenus;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

         //allUIMenus = GameObject.FindGameObjectsWithTag("SecondaryMenu");

        if(Input.GetKeyDown("tab"))
        {

            foreach (GameObject uiMenu in allUIMenus)
            {
                uiMenu.SetActive(false);
            }

            isPaused = !isPaused;

        }

        if(isPaused==true)
        {
            Cursor.visible = true;
            pauseMenu.SetActive(true);
        }
        

        if(isPaused==false)
        {
            Cursor.visible = false;
            pauseMenu.SetActive(false);
        }
    }



}
