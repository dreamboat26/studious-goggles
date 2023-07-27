using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public void TurnObstacleRed()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }   
}
