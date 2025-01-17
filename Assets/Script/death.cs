using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class death : MonoBehaviour
{
    public GameObject obg;
    public GameObject panel;

    public int numberScenes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0.0f;
            panel.SetActive(true);
        }
            

    }
}
