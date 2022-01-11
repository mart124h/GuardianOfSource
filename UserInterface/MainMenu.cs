using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject story;
    public GameObject userPlayerGun;
    public GameObject userPlayer;

    public void LoadLevel()
    {
        // load the nextlevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 
    }

    public void SpawnCharacter()
    {
        userPlayerGun.GetComponent<Gun>().canShoot = true;
        userPlayer.GetComponent<MenuHandler>().enabled = true;
        Destroy(this.gameObject);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public void OpenStory()
    {
        story.SetActive(true);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
