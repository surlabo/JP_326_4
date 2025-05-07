using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;
using System.Diagnostics.Contracts;

public class UIController : MonoBehaviour
{
    public GameObject InGamePanel;
    public GameObject StartPanel;

    public Button startGameBtn;
    public Toggle testToggle;


    private void Start()
    {
        startGameBtn.onClick.AddListener(StartGameMethod);
        testToggle.onValueChanged.AddListener(TestToggle);
    }

    public void StartGameMethod()
    {
        InGamePanel.SetActive(true);
        StartPanel.SetActive(false);
    }

    private void TestToggle(bool value)
    {

    }
}
