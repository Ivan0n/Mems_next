using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Authentication.ExtendedProtection;



public class craft_count : MonoBehaviour
{
    public static int mushromms = 0;
    public static int logs = 0;
    public TMP_Text mush_text;
    public TMP_Text logs_text;
    public int chk;
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
    public void clear()
    {
        mushromms = 0;
        logs = 0;
    }
    public void logs_plus()
    {
       
        logs += 1;
        logs_text.text = ": " + logs + " / 3";
        if (logs >= 3)
        {
            logs_text.text = "Done";
            chk += 1;
            cheker();
        }
    }
    public void mush_plus()
    {
        mushromms += 1;
        mush_text.text = ": " + mushromms + " / 5";
        if (mushromms >= 5)
        {
            mush_text.text = "Done";
            chk += 1;
            cheker();
        }
    }
    public void cheker()
    {
        if (chk == 2)
        {
            ender_game ga1 = GameObject.Find("deather").GetComponent<ender_game>();
            ga1.End();
        }
    }
}
