using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class craft_count : MonoBehaviour
{
    public int mushromms = 0;
    public TMP_Text mush_text;
    // Start is called before the first frame update
    void Start()
    {
        mush_text.text = ": " + mushromms + " / 5";
    }

    // Update is called once per frame
    void Update()
    {


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
