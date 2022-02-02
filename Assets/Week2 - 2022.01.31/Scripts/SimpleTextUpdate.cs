using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This script changes some text
/// </summary>
public class SimpleTextUpdate : MonoBehaviour
{

    public TMP_Text text;
    public string newText;
    [SerializeField]
    string otherText;

    // Start is called before the first frame update
    void Start()
    {
        text.text = newText;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            text.text = otherText;
        }

    }
}
