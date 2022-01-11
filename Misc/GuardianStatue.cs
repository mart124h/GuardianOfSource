using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianStatue : MonoBehaviour
{

    public GameObject statue;
    private GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GuardianTransform ()
    {
        statue.GetComponent<Animator>().SetBool("Transform", true);
        gameManager.GetComponent<GameManager>().attachmentPoints++;
        this.gameObject.GetComponent<GuardianStatue>().enabled = false;
    }
}
