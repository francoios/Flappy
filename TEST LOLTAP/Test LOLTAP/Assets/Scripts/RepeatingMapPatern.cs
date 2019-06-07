using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingMapPatern : MonoBehaviour
{
    private BoxCollider groundCollider;      
    private float groundHorizontalLength;      

    private void Awake()
    {                                                                                                                                                       
        groundCollider = GetComponent<BoxCollider>();
        groundHorizontalLength = groundCollider.size.x;
    }

    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
