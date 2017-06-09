using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileType{
    public string name;

    public GameObject tileVisPrefab;

    public bool isWalkable = true;

    public int movePen;

}
