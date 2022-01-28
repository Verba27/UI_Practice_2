using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    public string marketName;
    [SerializeField] private Slider sliderGem;
    [SerializeField] private Slider sliderCoin;
    [SerializeField] private Slider sliderPot;
    public float gemValue;
    public float coinValue;
    public float potValue;
    
    [SerializeField] private Market market;
    [SerializeField] private GameObject markImage;

    void Start()
    {
        markImage.SetActive(false);
    }
    
    public void OpenMarket()
    {
        MainManager.Instance.RememberValue(this);
        markImage.SetActive(true);
        
    }

    
    
}
