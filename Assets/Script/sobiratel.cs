using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobiratel : MonoBehaviour
{
    public int mushrooms = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " " + other.gameObject.tag);
        if (other.CompareTag("Player"))
        {

            Destroy(gameObject);
            mushrooms += 1;
            Debug.Log("Собрано" + mushrooms);
        }

        // Удаляем объект, к которому прикреплен этот скрипт

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
