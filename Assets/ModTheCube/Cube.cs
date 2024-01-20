using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 SpawnLocation;
    public float ScaleFactor = 1;
    public float xAngle = 50.0f;
    public float yAngle = 50.0f;
    public float zAngle = 50.0f;
    public Color ColorMix;
    
    void Start()
    {
        // allows user to change spawn location
        transform.position = SpawnLocation;
        SpawnLocation = new Vector3(0, 0, 0);
        
        transform.localScale = Vector3.one * ScaleFactor;
        
        Material material = Renderer.material;

        material.color = ColorMix;
        ColorMix = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void LateUpdate()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}
