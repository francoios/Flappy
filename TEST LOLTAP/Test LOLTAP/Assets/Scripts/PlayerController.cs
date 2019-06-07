using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;

    public bool IsDead;
    public static PlayerController Instance;

    public float UpForce;
    public float scrollSpeed = 3f;
    public bool ApplyFalling;

    public float Speed;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Awake()
    {
        ApplyFalling = true;
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
    }

    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.zero;
            _rb.AddForce(new Vector2(0, UpForce * 2),  ForceMode.Impulse);
            ApplyFalling = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("ScoreZone"))
        {
            GameManager.Instance.BirdScored();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Obstacle"))
        {
            GameManager.Instance.BirdDied();
            IsDead = true;
        }
    }
}
