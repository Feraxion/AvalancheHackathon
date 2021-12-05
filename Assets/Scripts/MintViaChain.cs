using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MintViaChain : MonoBehaviour
{
    public TMP_InputField inputFieldText;
    private string inputURL;
    public GameObject mintPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CallContract()
    {
        inputURL = inputFieldText.text;
        
        //inputUrl
        /////???????
    }

    public void CloseTab()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
