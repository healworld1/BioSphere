using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    // Use this for initialization
    Vector3[] corners = new Vector3[4];
    Transform selector;
    void Start () {
        selector = transform.GetChild(0);

        GetComponent<RectTransform>().GetWorldCorners(corners);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 relPos = Input.mousePosition - Camera.main.WorldToScreenPoint(corners[1]);
        Vector2 map = new Vector2(((int)relPos.x) / 60, ((int)relPos.y) / 60);
        if (map.x < 0 || map.x > 9 || map.y < -9 || map.y > 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            print("clicked " + map);
        } else
        {
            map.x *= 60;
            map.x += 30;
            map.y *= 60;
            map.y -= 30;
            selector.GetComponent<RectTransform>().anchoredPosition = map;
        }
        
    }

}
