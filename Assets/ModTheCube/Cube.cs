using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    // public Vector3 Pos = new Vector3 (0, 0, 0);
    public Vector3 scaleChange = new Vector3(5, 5, 5);
    public float scaleTimes = 1.5f;
    private Color color;
    private Vector3 rotate;
    private bool col = true;

    void Start()
    {
        transform.localScale = scaleChange * scaleTimes;

        // Material material = Renderer.material; 

        // material.color = color;
    }

    void Update()
    {

        if (col == true)
        {
            float randomColorR = Random.Range(0.0f, 1.0f);
            float randomColorG = Random.Range(0.0f, 1.0f);
            float randomColorB = Random.Range(0.0f, 1.0f);
            float randomColorA = Random.Range(0.0f, 1.0f);
            Material material = Renderer.material;
            material.color = new Color(randomColorR, randomColorG, randomColorB, randomColorA);
            col = false;
            // Debug.Log(randomColorR);
            Invoke("ColorChange", 1.0f);
        }

        float rotationX = Random.Range(2.0f, 10.0f);
        float rotationY = Random.Range(2.0f, 10.0f);
        float rotationZ = Random.Range(2.0f, 10.0f);
        transform.Rotate(rotationX * Time.deltaTime, rotationY * Time.deltaTime, rotationZ * Time.deltaTime);
    }

   

    void ColorChange()
    {
        col = true;
    }
}