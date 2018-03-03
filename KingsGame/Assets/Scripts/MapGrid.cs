using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGrid : MonoBehaviour {

    public GameObject[,] grid;

    public int X_Size, Y_Size;
    public GameObject walkableTile;
    public GameObject buildableTile;
    private Vector2 size;
    private void Start()
    {
        grid = new GameObject[X_Size, Y_Size];
        size = walkableTile.GetComponent<SpriteRenderer>().size;
        Vector3 offset = new Vector3(-X_Size / 2.0f + 0.5f, -Y_Size / 2.0f + 0.5f, 0.0f);
        for (int x = 0; x < X_Size; x++)
        {
            for (int y = 0; y < Y_Size; y++)
            {
                grid[x,y] =  (GameObject)Instantiate(walkableTile, new Vector3(x * size.x, y * size.y, 0) , Quaternion.identity);
            }
        }
    }
}