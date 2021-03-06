﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    public GameObject panelResume;
    public Transform parentDriver;
    public Button btnResume;
    // Start is called before the first frame update
    void Start()
    {
        btnResume.onClick.AddListener(()=>ShowPanelResume());
        panelResume.SetActive(false);
        if(CarsSelection.instance!=null)
            CarsSelection.instance.BaseSpawnModelById(PlayerPrefs.GetString("Player"), true, parentDriver, -11.8f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPanelResume()
    {
        panelResume.SetActive(true);
    }
}
