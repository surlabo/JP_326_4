using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;
using System.Diagnostics.Contracts;
using System.Data;
using System.Collections.Generic;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    public GameObject InGamePanel;
    public GameObject StartPanel;

    public Button startGameBtn;
    public Toggle testToggle;
    public Slider mySlider;
    public TMP_Dropdown dropdown;
    public Button PauseButton;
    public Button ResumeButton;

    private System.Collections.Generic.List<string> strings;
    


    private void Start()
    {
        int x = 2;
        MyClass myClass = new MyClass();
        startGameBtn.onClick.AddListener(StartGameMethod);
        testToggle.onValueChanged.AddListener(OnToggleClick);
        mySlider.onValueChanged.AddListener(OnSliderValueChange);

        List<TMP_Dropdown.OptionData> myOptionData = new List<TMP_Dropdown.OptionData>();
        myOptionData.Add(new TMP_Dropdown.OptionData("Option D"));

        dropdown.AddOptions(myOptionData);
        PauseButton.onClick.AddListener(OnPauseButtonClick);
        
        ResumeButton.onClick.AddListener(() => GameManager.Instance.isGamePoused = false);
    }

    private void OnPauseButtonClick()
    {
        GameManager.Instance.isGamePoused = true;
    }

    private void OnSliderValueChange(float arg0)
    {
        Debug.Log(mySlider.value);
    }

    public void StartGameMethod()
    {
        InGamePanel.SetActive(true);
        StartPanel.SetActive(false);
    }

    private void OnToggleClick(bool value)
    {
        Debug.Log(value);
    }

    

}

public class MyClass
{
    public int y;
    public string name;
    public bool isOld;
}
