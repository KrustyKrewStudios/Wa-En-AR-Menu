using Imagine.WebAR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMenu : MonoBehaviour
{
    public GameObject arCanvas;
    public ARCamera arCamera;
    public GameObject uiCanvas;

    public GameObject searedWagyu;
    public GameObject beefPlatter;
    public GameObject tata;
    public GameObject wagyuJyu;
    public GameObject salad;

    public GameObject placementIndicator;
    public GameObject placeButton;
    public WorldTracker worldTracker;

    void Start()
    {
       arCamera = GetComponent<ARCamera>();
       placementIndicator.SetActive(false);
        worldTracker = GetComponent<WorldTracker>();
        worldTracker.StopTracker();

    }

    public void ArMode()
    {
        arCamera.UnpauseCamera();
        arCanvas.SetActive(true);
        uiCanvas.SetActive(false);

    }
        
    public void NoAr()
    {
        arCamera.PauseCamera();
        arCanvas.SetActive(false);
        uiCanvas.SetActive(true);



    }

    public void SetSalad()
    {
        salad.SetActive(true);
        wagyuJyu.SetActive(false);
        tata.SetActive(false);
        beefPlatter.SetActive(false);
        searedWagyu.SetActive(false);
        uiCanvas.SetActive(false );
        placementIndicator.SetActive(true);


    }

    public void SetWagyuJyu() 
    {
        wagyuJyu.SetActive(true);
        tata.SetActive(false);
        beefPlatter.SetActive(false);
        searedWagyu.SetActive(false);
        salad.SetActive(false);
        uiCanvas.SetActive(false);
        placementIndicator.SetActive(true);
    }

    public void SetTata()
    {
        tata.SetActive(true);
        beefPlatter.SetActive(false);
        searedWagyu.SetActive(false);
        salad.SetActive(false);
        wagyuJyu.SetActive(false);
        uiCanvas.SetActive(false);
        placementIndicator.SetActive(true);
    }

    public void SetPlatter()
    {
        beefPlatter.SetActive(true);
        searedWagyu.SetActive(false);
        salad.SetActive(false);
        wagyuJyu.SetActive(false);
        tata.SetActive(false);
        uiCanvas.SetActive(false);
        worldTracker.StartTracker();
        placementIndicator.SetActive(true);

    }

    public void SetSearedWagyu()
    {
        searedWagyu.SetActive(true);
        salad.SetActive(false);
        wagyuJyu.SetActive(false);
        tata.SetActive(false);
        beefPlatter.SetActive(false);
        uiCanvas.SetActive(false);
        placementIndicator.SetActive(true);
        placeButton.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
