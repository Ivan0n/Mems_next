using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Animations;
using TMPro;

public class ender_game : MonoBehaviour
{
    public GameObject panel;
    public int numberScenes;
    public TMP_Text mushroom_text;
    public TMP_Text logs_text;
    public craft_count ga;

    public int mush = 0;
    public int logs = 0;


    // Start is called before the first frame update
    private void Start()
    {
        ga = GameObject.Find("Counter").GetComponent<craft_count>();
    }
    public void End()
    {
        mush = craft_count.mushromms;
        logs = craft_count.logs;
        ga.clear();
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0.0f;
        panel.SetActive(true);
        mushroom_text.text = " " + mush ;
        logs_text.text = " " + logs;
    }
}
