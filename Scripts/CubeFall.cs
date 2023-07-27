using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
            this.gameObject.GetComponentInParent<MeshRenderer>().enabled = true;
        }
    }
}
