using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {
    public TileType[] tileTypes;

    int[,] tiles;

    int mapSizeX = 10;
    int mapSizeY = 11;
    float commonOffsetx = 1.65f;
    float commonOffsety = 1.85f;
    public GameObject BeetleShip;

	// Use this for initialization
	void Start () {
        //allocate map tiles
        tiles = new int[mapSizeX, mapSizeY];

        //Initialize our map tiles
        for(int x = 0; x < mapSizeX; x++)
        {
            for(int y = 0; y < mapSizeY; y++)
            {
                tiles[x, y] = 0;
            }
        }
        GenerateMapVisual();
		
	}
    void GenerateMapVisual ()
    {
        // Makes Grid seeable
        for (int x = 0; x < mapSizeX; x ++)
        {
            for(int y = 0; y < mapSizeY ; y++ )
            {
                // changey is for the map offset to make the hex grid fit
                float changey = y + .5f;
                // commonOffset is so that it fits the map
                if ((x % 2) == 0)
                {
                    TileType tt = tileTypes[tiles[x, y]];
                    GameObject TempForClicking = (GameObject)Instantiate(tt.tileVisPrefab, new Vector3(transform.position.x + (x*commonOffsetx), transform.position.y + (changey*commonOffsety), 0), Quaternion.identity);
                    // This gives each particular block their coordinate position, Will see this again in the else statement
                    Clickablility Clickity = TempForClicking.GetComponent<Clickablility>();
                    Clickity.LocX = transform.position.x + (x*commonOffsetx);
                    Clickity.LocY = transform.position.y + (changey * commonOffsety);
                    Clickity.Map = this;
                }
                else
                {
                    TileType tt = tileTypes[tiles[x, y]];
                    GameObject TempForClicking = (GameObject)Instantiate(tt.tileVisPrefab, new Vector3(transform.position.x + (x*commonOffsetx), transform.position.y + (y*commonOffsety), 0), Quaternion.identity);
                    Clickablility Clickity = TempForClicking.GetComponent<Clickablility>();
                    Clickity.LocX = transform.position.x + (x * commonOffsetx);
                    Clickity.LocY = transform.position.y + (y * commonOffsety);
                    Clickity.Map = this;
                }
            }
        }
    }

    public void MoveSelf(float x, float y)
    {
        BeetleShip.transform.position = new Vector3(x, y, 0);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
