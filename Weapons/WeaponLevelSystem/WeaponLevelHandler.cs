using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponLevelHandler : MonoBehaviour
{
    
    public GameObject gunPrefab;
    public GameManager gameManager;

    public int currentLevel;
    public int nextLevel;
    public int currentKills;
    private int progressCap;

    public int level1Xp = 25;
    public int level2Xp = 50;
    public int level3Xp = 100;
    public int level4Xp = 200;


    //UI Setup
    public Text progressText;
    public Text currentLevelText;
    public Text nextLevelText;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        nextLevelText.text = "Level " + nextLevel;
        currentLevelText.text = "Level " + currentLevel;


        if(gunPrefab.gameObject.name=="Pistol")
        {
            currentKills = gameManager.GetComponent<GameManager>().pistolKills;
        }

        if(gunPrefab.gameObject.name=="AutomaticRifle")
        {
            currentKills = gameManager.GetComponent<GameManager>().arKills;
        }

        CurrentLevel();

    }

    void CurrentLevel()
    {
        //Level 0
        if(currentKills<=0 && currentKills<level1Xp)
        {
            currentLevel = 0;
            nextLevel = 1;
            progressCap = level1Xp;
        }

        //Level 1
        if(currentKills>=level1Xp && currentKills<level2Xp)
        {
            currentLevel = 1;
            nextLevel = 2;
            progressCap = level2Xp;

        }

        //Level 2
        if(currentKills>=level2Xp && currentKills<level3Xp)
        {
            currentLevel = 2;
            nextLevel = 3;
            progressCap = level3Xp;


        }

          //Level 3
        if(currentKills>=level3Xp && currentKills<level4Xp)
        {
            currentLevel = 3;
            nextLevel = 4;
            progressCap = level4Xp;


        }

          //Level 4
        if(currentKills>=level4Xp)
        {
            currentLevel = 4;
            nextLevel = 4;
            progressCap = level4Xp;


        }

        if(currentLevel!=4)
        progressText.text = "" + currentKills + " / " + progressCap + "Kills";
        else
        progressText.text = "WEAPON MASTERED";

    }
}
