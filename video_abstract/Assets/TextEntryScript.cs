using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public class TextEntryScript : MonoBehaviour
{

    public enum MODES { FADING, GAMEPLAY, TEXTBOX };
    public MODES mode;

    public TMP_Text textboxText;
    public GameObject textbox;
    public string[] textEntries;

    // Start is called before the first frame update
    void Start()
    {
        mode = MODES.FADING;
        StartCoroutine(introTextSequence());
    }

    IEnumerator introTextSequence()
    {
        mode = MODES.TEXTBOX;

        textbox.SetActive(true);
        textboxText.text = textEntries[0];
        int count = 0;
        while (count < textEntries.Length)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                count++;
                if (count < textEntries.Length)
                {
                    textboxText.text = textEntries[count];
                }
            }
            yield return null;
        }
        textbox.SetActive(false);

        mode = MODES.GAMEPLAY;
    }

}
