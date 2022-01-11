using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int rockAmmo;
    public int pistolAmmo;
    public int arAmmo;

    public int pistolKills;
    public int arKills;

    public int totalKills;
    
    public int attachmentPoints;

    public int collectCollectables;
    public int totalCollectables;
    public GameObject gameCursor;
    public GameObject activateIcon;
    public GameObject shootIcon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       totalKills = arKills+pistolKills;
    }
}
