using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTimer : MonoBehaviour
{

    public float duration;

    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Downcounting");
    }

     IEnumerator Downcounting()
    {
        yield return new WaitForSeconds(duration);
        this.gameObject.SetActive(false);
    }

}
