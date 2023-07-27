using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPole : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 2.0f;

    //private Rigidbody poleRB;

    // Start is called before the first frame update
    void Start()
    {
        //this.poleRB = this.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        this.gameObject.transform.Rotate(Vector3.up * this.rotationSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Quaternion deltaRotation = Quaternion.Euler(Vector3.up * this.rotationSpeed * Time.fixedDeltaTime);
        //this.poleRB.MoveRotation(this.poleRB.rotation * deltaRotation);
        //this.poleRB.rotation *= deltaRotation;
    }
}
