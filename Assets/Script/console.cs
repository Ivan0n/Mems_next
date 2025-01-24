using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class console : MonoBehaviour
{
    public GameObject panel;
    public GameObject spawn_panel;
    public TextMeshProUGUI consoleText;
    private string logMessages = "";
    public TMP_InputField inputField;
    public string input;


    //Объекты для консоли
    public GameObject nextbots;
    // Start is called before the first frame update
    void conslog()
    {
        Application.logMessageReceived += HandleLog;
    }
    void Start()
    {
        conslog();
    }
    public void GetInputText()
    {
        input = inputField.text; // Получаем текст из Input Field
        Debug.Log(input);
        commands();
        // Отображаем текст на экране (если нужно)
        logMessages += input + "\n";
    }
    void HandleLog(string logString, string stackTrace, LogType type)
    {
        // Добавляем новое сообщение к логам
        logMessages += logString + "\n";

        // Ограничиваем количество строк (например, последние 10 строк)
        string[] lines = logMessages.Split('\n');
        if (lines.Length > 10)
        {
            logMessages = string.Join("\n", lines, lines.Length - 10, 10);
        }

        // Обновляем текст на экране
        consoleText.text = logMessages;
    }
    public void commands()
    {
        ender_game ender = GameObject.Find("deather").GetComponent<ender_game>();
        scenmanager scen = GameObject.Find("deather_scenes").GetComponent<scenmanager>();
        if (input == "end")
        {
            Debug.Log("End game");

            ender.End();
        }
        else if (input == "+nextbots")
        {
            Debug.Log("Nextbots ON!!!");
            nextbots.SetActive(true);
        }
        else if (input == "-nextbots")
        {
            Debug.Log("Nextbots OFF!!!");
            nextbots.SetActive(false);
        }
        else if (input == "menu")
        {
            Debug.Log("Menu");
            scen.changeScenes(0);
        }
        else if (input == "+spawner")
        {
            Debug.Log("Spawn menu");
            spawn_panel.SetActive(true);
        }
        else if (input == "-spawner")
        {
            Debug.Log("Spawn menu");
            spawn_panel.SetActive(false);
        }
        else if (input == "reload_map")
        {
            Debug.Log("Reload");
            scen.changeScenes(1);
        }
        else if (input == "spawner")
        {
            Debug.Log("Spawner menu");

        }
        else
        {
            Debug.Log("Error, Wrong command!!!");
        }
    }

    private int open_chek = 0;
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetInputText();
        }
        if (Input.GetKeyDown(KeyCode.F7))
        {
            Debug.Log("Console");
            Cursor.lockState = CursorLockMode.Confined;
            panel.SetActive(true);
            if (open_chek == 0)
            {
                Debug.Log("Console Open");
                Cursor.lockState = CursorLockMode.Confined;
                panel.SetActive(true);
                open_chek = 1;
            }
            else
            {
                open_chek = 0;
                panel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Debug.Log("Console Close");
            }



        }
    }
}
