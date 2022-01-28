using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Market : MonoBehaviour
{
    
    [SerializeField] private GameObject marketWindow;
    [SerializeField] private InputField inputField;

    [SerializeField] private Slider sliderGem;
    [SerializeField] private Slider sliderCoin;
    [SerializeField] private Slider sliderPot;
    private LevelButton _level;
private void Awake()
    {
        sliderGem.onValueChanged.AddListener(HandleGem);
        sliderCoin.onValueChanged.AddListener(HandleCoin);
        sliderPot.onValueChanged.AddListener(HandlePot);
        marketWindow.SetActive(false);
    }

    public void SetData(LevelButton level)
    {
        _level = level;
        sliderGem.value = level.gemValue;
        sliderCoin.value = level.coinValue;
        sliderPot.value = level.potValue;
    }
    private void HandlePot(float arg0)
    {
        MainManager.Instance.ButtonValuePot(_level, arg0);
    }

    private void HandleCoin(float arg0)
    {
        MainManager.Instance.ButtonValueCoin(_level, arg0);
    }

    private void HandleGem(float arg0)
    {
        MainManager.Instance.ButtonValueGem(_level, arg0);
    }

    public void CloseMarket()
    {
        marketWindow.SetActive(false);
    }

    public void OpenMarketWindow(string name)
    {
        marketWindow.SetActive(true);
        inputField.text = name;
    }
    
}
