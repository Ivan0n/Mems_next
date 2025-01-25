using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    

    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Menu");
            UnityEngine.Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("menu");
        }
    }
}
