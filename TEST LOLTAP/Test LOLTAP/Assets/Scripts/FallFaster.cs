using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFaster : MonoBehaviour
{
    [Tooltip("The greater, the fast you fall")]
    [Range(1, 10)]
    [SerializeField]
    private float _fallMultiplier = 1;
    [Range(1, 100)]
    public float BonusGrav;
    private Rigidbody _rb;

    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
        }
        else if (_rb.velocity.y >= 0)
        {
            Vector3 vel = _rb.velocity;
            vel.y -= BonusGrav * Time.deltaTime;
            _rb.velocity = vel;
        }
    }
}
