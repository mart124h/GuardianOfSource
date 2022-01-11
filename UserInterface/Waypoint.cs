using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{

    public RectTransform prefab;

    private RectTransform waypoint;

    private Transform userPlayer;

    private Text distanceText;

    public Vector3 offSet = new Vector3(0, 1.25f, 0);

    public Transform canvas;



    // Start is called before the first frame update
    void Start()
    {
        waypoint = Instantiate(prefab, canvas);
        distanceText = waypoint.GetComponentInChildren<Text>();



    }

    // Update is called once per frame
    void Update()
    {

        userPlayer = GameObject.Find("UserPlayer").transform;
        

        var screenPos = Camera.main.WorldToScreenPoint(transform.position + offSet);
        waypoint.position = screenPos;

       waypoint.gameObject.SetActive(screenPos.z > 0);

        distanceText.text = Vector3.Distance(userPlayer.position, transform.position).ToString("0") + "m";
    }
}
