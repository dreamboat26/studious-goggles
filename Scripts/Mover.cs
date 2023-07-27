using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float rotationX = 0f;
    float rotationZ = 0f;
    [SerializeField] float rotSpeed = 100.0f;
    [SerializeField] private float maxRot = 15.0f;
    [SerializeField] private float minRot = -15.0f;

    Rigidbody planeRB;

    

    // Start is called before the first frame update
    void Start()
    {
        this.planeRB = this.gameObject.GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked; //At start, lock the mouse pointer to the center of the game window
        Cursor.visible = false; //After locking the mouse pointer, hide it so it doesn't hide the crosshair
    }

    // Update is called once per frame
    void Update()
    {
        float mouseZ = Input.GetAxisRaw("Mouse X") * this.rotSpeed * Time.deltaTime;
        float mouseX = Input.GetAxisRaw("Mouse Y") * this.rotSpeed * Time.deltaTime;

        this.rotationX += mouseX;
        this.rotationZ -= mouseZ;

        this.rotationX = Mathf.Clamp(this.rotationX, this.minRot, this.maxRot);
        this.rotationZ = Mathf.Clamp(this.rotationZ, this.minRot, this.maxRot);
    }

    private void FixedUpdate()
    {
        this.planeRB.MoveRotation(Quaternion.Euler(this.rotationX, 0, this.rotationZ));
    }
}
