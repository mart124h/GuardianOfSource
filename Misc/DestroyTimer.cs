using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public bool dectivateDestroy = false;
    public float destroyTimer;

    // Start is called before the first frame update
    void Update()
    {   
        if(dectivateDestroy==false)
        {
       
        StartCoroutine("Destroy");

        }
    }

    // Update is called once per frame
    void OnCollisionHit(Collision col)
    {
        if(col.gameObject.tag == "DamagePrefab")
        {

            dectivateDestroy = false;
        
        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(destroyTimer);
        Destroy(this.gameObject);
    }
}
