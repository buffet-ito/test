using UnityEngine;
using System.Collections;

public class action : MonoBehaviour {
    Material material;
    Color color = Color.white;

    void Start()
    {
        material = Resources.Load<Material>("Materials/TestMaterial");
    }

    void Update()
    {
        
    }

    public void SetThreshold(float threshold)
    {
        material.SetFloat("_threshold", threshold);
    }

    public void SetColor()
    {
        material.SetColor("_Color", color);
    }

    public void SetRed(float r)
    {
        color.r = r;
        SetColor();
    }

    public void SetGreen(float g)
    {
        color.g = g;
        SetColor();
    }

    public void SetBlue(float b)
    {
        color.b = b;
        SetColor();
    }
}
