using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobiratel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Destroy(gameObject);
        // Удаляем объект, к которому прикреплен этот скрипт

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
