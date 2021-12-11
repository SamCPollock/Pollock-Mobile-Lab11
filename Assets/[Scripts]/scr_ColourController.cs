using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class scr_ColourController : MonoBehaviour
{
    public Color platformColour;

    private List<SpriteRenderer> tileSpriteRenderers;
    void Start()
    {
        tileSpriteRenderers = GetComponentsInChildren<SpriteRenderer>().ToList();
        SetColour();
    }

    void Update()
    {
        
    }


    public void SetColour()
    {
        foreach (var renderer in tileSpriteRenderers)
        {
            renderer.material.SetColor("_Color", platformColour);
        }
    }

    public void SetColour(Color colour)
    {
        foreach (var renderer in tileSpriteRenderers)
        {
            renderer.material.SetColor("_Color", platformColour);
        }
    }
}
