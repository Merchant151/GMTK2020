using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid : MonoBehaviour
{
    public int length;
    public int width;
    public float size;

    private int[,] grid;

    public WorldGrid()
    {
        length = 4;
        width = 4;
        size = 10;

        grid = new int[length, width];
    }





}
