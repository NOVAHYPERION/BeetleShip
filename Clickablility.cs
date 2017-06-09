using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickablility : MonoBehaviour {
    public TileMap Map;
	public float LocX;
    public float LocY;
    
    void OnMouseUp()
    {
        Debug.Log("FUCK");
        Debug.Log(LocX);
        Debug.Log(LocY);
        Map.MoveSelf(LocX, LocY);
    }

}
