using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideViewFollower : MonoBehaviour
{
    public GameObject Player;

    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(Player.transform.position.x, 0, Player.transform.position.z) + _offset;
    }
}
