using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    // Use this for initialization
    Vector2 corner = new Vector2(-500, 500);
    Transform selector;
    void Start () {
        selector = transform.GetChild(0);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 mousePos = GetMousePos();
        if (mousePos.x < -500 || mousePos.x > 500 || mousePos.y > 500 || mousePos.y < -500)
        {
            return;
        }
        Vector2 relPos = GetMousePos() - corner;
        Vector2 map = new Vector2(((int)relPos.x) / 100 * 100 + 50, ((int)relPos.y) / 100 * 100 - 50);
        if (Input.GetMouseButtonDown(0))
        {
            print("clicked " + map);
        } else
        {
            selector.GetComponent<RectTransform>().anchoredPosition = map;
        }
        
    }

    Vector2 GetMousePos()
    {
        Vector2 mouse = Input.mousePosition;
        mouse.x -= Screen.width / 2;
        mouse.y -= Screen.height / 2;
        return mouse;
    }

}
