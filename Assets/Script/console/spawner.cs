using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    public GameObject player;

    

    public GameObject teleporter;
    public Button teleport_but;

    private int cheker = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void teleport_spawn()
    {
        float x = player.transform.position.x;
        float y = player.transform.position.y;
        float z = player.transform.position.z;
        
        Debug.Log("Координаты объекта: " + x + y + z);
        GameObject clone = Instantiate(teleporter);
        clone.transform.position = new Vector3(x + 5, y + 1, z);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (cheker == 0)
            {
                UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                cheker = 1;
            }
            else
            {
                UnityEngine.Cursor.lockState = CursorLockMode.Locked;
                cheker = 0;
            }
            
        }
    }
}
