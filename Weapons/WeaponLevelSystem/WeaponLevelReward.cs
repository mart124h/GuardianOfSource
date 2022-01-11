using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLevelReward : MonoBehaviour
{
    
    public GameObject weaponLevelHandler;

    public float improvementValue;

    public float newValue;

    public bool collected;

    public GameObject parent;
    
    // Start is called before the first frame update
    void Start()
    {
        newValue = weaponLevelHandler.GetComponent<WeaponLevelHandler>().gunPrefab.GetComponent<Gun>().fireRate/100*improvementValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(collected==true)
        {
            parent.gameObject.GetComponent<Animator>().SetBool("Collected", true);
        }
    }

    public void CollectReward()
    {
        if(collected==false)
        {
            weaponLevelHandler.GetComponent<WeaponLevelHandler>().gunPrefab.GetComponent<Gun>().fireRate-=newValue;
            collected = true;

        }

    }
}
