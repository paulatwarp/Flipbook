using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipbook : MonoBehaviour
{
    public CreateTiles tiler;
    new Renderer renderer;
    Material material;
    float time;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        material = renderer.material;
    }

    private void Update()
    {
        time += Input.GetAxis("Horizontal") * Time.deltaTime * (tiler.width * tiler.height);
        if (time < 0.0f)
        {
            time = 0.0f;
        }
        material.SetFloat("_Width", tiler.width);
        material.SetFloat("_Height", tiler.height);
        material.SetFloat("_Tile", time);
    }
}
