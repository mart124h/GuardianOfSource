using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 


public class SwitchScene : MonoBehaviour
{

    public string levelString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("l"))
        {
            loadlevel();
        }
    }

    public void loadlevel()
    {

        SceneManager.LoadScene(levelString);
 
    }
}
