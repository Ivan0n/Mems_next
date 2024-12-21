using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform pos;
    public GameObject obg;

    private void OnTriggerEnter(Collider other) {
        other.transform.position = pos.transform.position;
        
    }
}
