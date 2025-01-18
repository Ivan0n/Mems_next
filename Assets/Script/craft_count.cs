using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class craft_count : MonoBehaviour
{
    public int mushromms = 0;
    public int logs = 0;
    public TMP_Text mush_text;
    public TMP_Text logs_text;
    // Start is called before the first frame update
    void Start()
    {
        mush_text.text = ": " + mushromms + " / 5";
        logs_text.text = ": " + logs + " / 3";
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void logs_plus()
    {
        logs += 1;
        logs_text.text = ": " + logs + " / 3";
        if (logs >= 3)
        {
            logs_text.text = "Done";
        }
    }
    public void mush_plus()
    {
        mushromms += 1;
        mush_text.text = ": " + mushromms + " / 5";
        if (mushromms >= 5)
        {
            mush_text.text = "Done";
        }
    }
}
