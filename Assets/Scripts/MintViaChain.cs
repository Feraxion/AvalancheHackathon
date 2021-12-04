using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MintViaChain : MonoBehaviour
{
    public TMP_InputField inputFieldText;
    private string inputURL;
    
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
