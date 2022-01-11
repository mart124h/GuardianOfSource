using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   public Canvas parentCanvas;
   public Transform toolTip;
   public Vector2 offSet = new Vector2(-2.3f,-2.1f);
   public bool mouse_over = false;


    public void Start()
    {

          Vector2 pos;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                parentCanvas.transform as RectTransform, Input.mousePosition,
                parentCanvas.worldCamera,
                out pos);

    }   

    public void Update()
    {
        
        if(mouse_over==true)
        {
            toolTip.gameObject.SetActive(true);

        Vector2 movePos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            Input.mousePosition, parentCanvas.worldCamera,
            out movePos);

            movePos+=offSet;

        toolTip.transform.position = parentCanvas.transform.TransformPoint(movePos);
        }

        if(mouse_over==false)
        {
            toolTip.gameObject.SetActive(false);
        }
    }

    
 
     public void OnPointerEnter(PointerEventData eventData)
     {
         mouse_over = true;
         Debug.Log("Mouse enter");
     }
 
     public void OnPointerExit(PointerEventData eventData)
     {
         mouse_over = false;
         Debug.Log("Mouse exit");
     }
 }

