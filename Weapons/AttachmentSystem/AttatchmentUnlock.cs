using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttatchmentUnlock : MonoBehaviour
{

    public AttachmentHandler attachmentHandler;
    public GameObject attatchmentBlock;
    public GameObject attatchmentTab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UnlockAttachment()
    {
        if(attachmentHandler.attachmentPoints>=1)
        {   
            attatchmentTab.SetActive(true);
            attachmentHandler.attachmentPoints-=1;
            attatchmentBlock.GetComponent<Attachment>().unlocked = true;
            this.gameObject.SetActive(false);
        }
    }
}
