using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttachmentHandler : MonoBehaviour
{

    public int attachmentPoints;
    public int attachmentCap = 2;
    public int attachmentEquipped;

    public Text attachmentCountText;
    public Text attachmentPointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attachmentPointText.text = "Points: " + attachmentPoints;
        attachmentCountText.text = "" + attachmentEquipped + " / " + attachmentCap;
    }
}
