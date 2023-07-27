using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongObstacle : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(Vector3.up * this.rotationSpeed * Time.deltaTime);
    }
}
