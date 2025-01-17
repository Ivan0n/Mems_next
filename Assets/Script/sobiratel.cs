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
            craft_count ga = GameObject.Find("Counter").GetComponent<craft_count>();
            Destroy(gameObject);
            mushrooms += 1;
            Debug.Log("Собрано" + mushrooms);
            ga.mush_plus();
        }

        // Удаляем объект, к которому прикреплен этот скрипт

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
