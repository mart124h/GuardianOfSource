using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ArsenalTab : MonoBehaviour
{

    public GameObject GameManager;

    public Gun weaponPrefab;


    //Text Objects
    public GameObject killCounterText;
    public GameObject weaponNameText;
    public GameObject damageText;
    public GameObject fireRateText;


    public void Start ()
    {
        GameManager = GameObject.Find("GameManager");
    }

    public void Update()
    {
        weaponNameText.GetComponent<Text>().text = weaponPrefab.gameObject.name;
        fireRateText.GetComponent<Text>().text = "Firerate: " + weaponPrefab.fireRate.ToString();
        
        if(weaponPrefab.gameObject.name=="Pistol")
        {
        
        killCounterText.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().pistolKills.ToString() + " Kills";

        }

        if(weaponPrefab.gameObject.name=="AutomaticRifle")
        {
        
        killCounterText.GetComponent<Text>().text = GameManager.GetComponent<GameManager>().arKills.ToString() + " Kills";

        }

        
    }





}
