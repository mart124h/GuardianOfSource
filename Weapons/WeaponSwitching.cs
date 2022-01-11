using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    
    public GameObject gameManager;
    
    // Pistol Setup
    public GameObject pistol;
    public bool pistolEquipped;

    // AR Setup
    public GameObject assaultRifle;
    public bool assaultRifleEquipped;

    public GameObject noAmmoUI;

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameManager");
    }

    public void PistolSwitch()
    {
         pistol.SetActive(true);
            assaultRifle.SetActive(false);
            if(gameManager.GetComponent<GameManager>().pistolAmmo>0)
            {
                pistol.GetComponent<Gun>().canShoot = true;
            }
    }

    public void ARSwitch()
    {
            assaultRifle.SetActive(true);
            pistol.SetActive(false);
            assaultRifle.GetComponent<Gun>().canShoot = true;
    }

    public void NOUI()
    {
            noAmmoUI.SetActive(true);
            PistolSwitch();

    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown("1"))
        {
           
            PistolSwitch();
            
        }
        
        if(Input.GetKeyDown("2") && gameManager.GetComponent<GameManager>().arAmmo>0)
        {
           
           ARSwitch();
            
        }

        if(Input.GetKeyDown("2") && gameManager.GetComponent<GameManager>().arAmmo<=0)
        {
            NOUI();
        }

    }
}
