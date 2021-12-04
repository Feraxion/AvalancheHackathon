using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class ArcadeMachine : MonoBehaviour
{
    public string webGLAddress; 
    public OpenLinkProxy openUrlLib;
    SpriteRenderer sr;
    public Color highlightColor;
    public Color defaultColor;

    public VideoClip videoClip;
    public VideoPlayer vp;
    public int gameSceneBuildIndex;
    
    public GameObject playTexture;
    
    public GameObject rentMintPanel;
    
    bool isEmpty;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Highlight()
    {
        playTexture.SetActive(true);
        vp.clip = videoClip;
        vp.Play();

        sr.color = highlightColor;
    }
    public void UnHighlight()
    {
        playTexture.SetActive(false);
        vp.Stop();
        sr.color = defaultColor;
    }

    public void Interaction()
    {
        if (!isEmpty)
        {

            Debug.Log("This is " + gameObject.name);
           openUrlLib.OpenWebsite(webGLAddress);

        }
        else
        {
            rentMintPanel.SetActive(true);
        }
    }
}