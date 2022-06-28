using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    public Material[] wallMaterial;
    Renderer rend;

    public Text displayText;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        //displayText.text = "";
    }

    private void OnCollisionEnter(Collision col)
    {
        // Checks if the player ball has collided with the wall.
        if (col.gameObject.name == "Ball")
        {
            //displayText.text = "Ouch!";
            rend.sharedMaterial = wallMaterial[0];
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            rend.sharedMaterial = wallMaterial[1];
            //displayText.text = "Keep Rolling...";
        }
    }
}
