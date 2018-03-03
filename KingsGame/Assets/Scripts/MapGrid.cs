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
        //size = walkableTile.GetComponent<SpriteRenderer>().size;
        for (int x = 0; x < X_Size; x++)
        {
            for (int y = 0; y < Y_Size; y++)
            {
                //grid[x,y] =  (GameObject)Instantiate(walkableTile, new Vector3(x * size.x, y * size.y, 0), Quaternion.identity);
            }
        }
    }
}

//var offset = Vector3(-cols / 2.0 + 0.5, -rows / 2.0 + 0.5, 0.0);
     
//     for (var i = 0; i<rows; i++) {
//         for (var j = 0; j<cols; j++) {
//             Instantiate(prefab, Vector3(j, i, 0.0) + offset, Quaternion.identity);
//         }
//     }
