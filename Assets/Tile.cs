using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TMP_Text text;

    public void Number(int n)
    {
        text.text = n.ToString();
    }
}
