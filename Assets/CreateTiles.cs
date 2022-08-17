using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateTiles : MonoBehaviour
{
    public GridLayoutGroup grid;
    public Tile prefab;
    public TMP_Text widthUI;
    public TMP_Text heightUI;
    public int width = 6;
    public int height = 6;
    List<Tile> tiles = new List<Tile>();

    private void Start()
    {
        Generate(width, height);
    }

    private void Update()
    {
        bool change = false;
        if (Input.GetButtonDown("Fire1"))
        {
            width++;
            change = true;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (width > 2)
            {
                width--;
                change = true;
            }
        }
        if (Input.GetButtonDown("Fire3"))
        {
            height++;
            change = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (height > 2)
            {
                height--;
                change = true;
            }
        }

        if (change)
        {
            Generate(width, height);
        }

        widthUI.text = $"Width: {width}";
        heightUI.text = $"Height: {height}";
    }

    public void Generate(int w, int h)
    {
        grid.cellSize = new Vector2(2048.0f / width, 2048.0f / height);

        foreach (Tile tile in tiles)
        {
            Destroy(tile.gameObject);
        }
        tiles.Clear();

        for (int i = 0; i < w * h; ++i)
        {
            Tile tile = Instantiate(prefab, transform);
            tile.Number(i);
            tile.name = $"Tile {i}";
            tiles.Add(tile);
        }
    }
}
