using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLevelTab : MonoBehaviour
{

    public GameObject weaponLevelHandler;
    public int unlockRequirement;

    public GameObject uiTab;
    public GameObject lockedUiTab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(weaponLevelHandler.GetComponent<WeaponLevelHandler>().currentLevel>=unlockRequirement)
        {
            uiTab.SetActive(true);
        }
        else
        {
            uiTab.SetActive(false);
            lockedUiTab.SetActive(true);
        }
    }
}
