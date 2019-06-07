using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = new Vector3(-PlayerController.Instance.scrollSpeed, 0);
    }

    void Update()
    {
        if (PlayerController.Instance.IsDead == true)
        {
            _rb.velocity = Vector2.zero;
        }
    }
}
