using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attachment : MonoBehaviour
{
    
    
    
    public AttachmentHandler attachmentHandler;
    public Gun weaponPrefab;
    public GameObject attachmentPrefab;
    public bool unlocked;
    public float fireRateIncrease;
    public float shootingPowerIncrease;
    public float damageIncrease;
    public bool equipped;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
      
    }

    public void EquipAttachment()
    {

        if(unlocked==true)
        {
            
            if(attachmentHandler.attachmentEquipped<attachmentHandler.attachmentCap && equipped == false)
            {
                weaponPrefab.shootingPower+=shootingPowerIncrease;
                weaponPrefab.fireRate-=fireRateIncrease;
                attachmentHandler.attachmentEquipped+=1;
                attachmentPrefab.SetActive(true);
                equipped = true;

            }

            else if(equipped==true)
            {

                weaponPrefab.shootingPower-=shootingPowerIncrease;
                weaponPrefab.fireRate+=fireRateIncrease;
                attachmentHandler.attachmentEquipped-=1;
                attachmentPrefab.SetActive(false);
                equipped = false;

            }

         

        }

      

    }


}
