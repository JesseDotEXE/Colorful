using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ColorController : MonoBehaviour 
{    
    public Color c1;
    public Color c2;
    public Color c3;
    public Color c4;
    public Color c5;
    public Color white;
    public Image crosshair;

    private Color[] colors;
    private Color currentColor;
    private int currentColorIndex;

    // Use this for initialization
    void Start () 
    {
        SetupColors();   
    }
	
	// Update is called once per frame
	void Update () 
    {
        DoRaycast();
        ChangeColor();
    }

    void DoRaycast() {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray colorRay;

            colorRay = new Ray(gameObject.transform.position, gameObject.transform.forward);

            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 100.0f))
            {
                if (hit.collider.gameObject.tag == "Colorable")
                {
                    print("Hitting colorable object.");
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = currentColor;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            RaycastHit hit;
            Ray colorRay;

            colorRay = new Ray(gameObject.transform.position, gameObject.transform.forward);

            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 100.0f))
            {
                if (hit.collider.gameObject.tag == "Colorable")
                {
                    print("Hitting colorable object.");
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = white;
                }
            }
        }
    }

    void ChangeColor()
    {
        if(Input.GetKeyDown(KeyCode.Q)) 
        {
            if (currentColorIndex == 0)
            {
                currentColorIndex = 4;
            }
            else
            {
                currentColorIndex--;
            }
            currentColor = colors[currentColorIndex];
            UpdateColorIndicator();
        } 
        else if(Input.GetKeyDown(KeyCode.E)) 
        {
            if (currentColorIndex == 4)
            {
                currentColorIndex = 0;
            }
            else
            {
                currentColorIndex++;
            }
            currentColor = colors[currentColorIndex];
            UpdateColorIndicator();
        }
    }

    void UpdateColorIndicator() 
    {
        crosshair.color = currentColor;
    }

    void SetupColors() 
    {
        currentColorIndex = 0;
        colors = new Color[5];
        colors[0] = c1;
        colors[1] = c2;
        colors[2] = c3;
        colors[3] = c4;
        colors[4] = c5;
        currentColor = colors[currentColorIndex];
        UpdateColorIndicator();
    }
}
