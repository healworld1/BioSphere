using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
    public GameObject building;
    // Use this for initialization
    Vector3[] corners = new Vector3[4];
    GameObject[,] buildings = new GameObject[10, 10];
    Transform selector;

    void Start () {
        selector = transform.GetChild(0);

        GetComponent<RectTransform>().GetWorldCorners(corners);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 relPos = Input.mousePosition - Camera.main.WorldToScreenPoint(corners[1]);
        Vector2Int map = new Vector2Int(((int)relPos.x) / 60, ((int)relPos.y) / 60);
        Vector2 mapPos = map;
        mapPos.x *= 60;
        mapPos.x += 30;
        mapPos.y *= 60;
        mapPos.y -= 30;
        if (map.x < 0 || map.x > 9 || map.y < -9 || map.y > 0)
        {
            selector.gameObject.SetActive(false);
            return;
        } else
        {
            selector.gameObject.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            print(map);
            buildings[map.x, -map.y] = Instantiate(building,transform);
            buildings[map.x, -map.y].GetComponent<RectTransform>().anchoredPosition = mapPos;
            return;
        } else
        {
            selector.GetComponent<RectTransform>().anchoredPosition = mapPos;
        }
        
    }
}
