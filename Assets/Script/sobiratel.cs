using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobiratel : MonoBehaviour
{
    
    public int id = 0; 
    //id = 1 - гриб
    //id = 2 - бревно
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
            if (id == 1)
            {
                
                Destroy(gameObject);
                
                Debug.Log("Собрано");
                ga.mush_plus();
            }
            else if(id == 2)
            {
                
                Destroy(gameObject);
                
                Debug.Log("Собрано");
                ga.logs_plus();
            }
            
        }

        // Удаляем объект, к которому прикреплен этот скрипт

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
