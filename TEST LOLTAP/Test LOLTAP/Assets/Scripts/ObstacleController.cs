using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [Range(-20,20)]
    public int ObstaclePlacement;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(this.transform.position.x, ObstaclePlacement, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnValidate()
    {
        this.transform.position = new Vector3(this.transform.position.x, ObstaclePlacement, this.transform.position.z);
    }
}
