using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    private LevelButton LevelButton;
    [SerializeField] private Market market;
    private GameObject buttonCurrent;
    private GameObject buttonPrevious;
    
    public void RememberValue(LevelButton levelButton)
    {
        buttonPrevious = buttonCurrent;
        //TODO getoff mark from previous
        market.SetData(levelButton);
        market.OpenMarketWindow(levelButton.marketName);
        buttonCurrent = levelButton.gameObject;
        
    }

    public void ButtonValueGem(LevelButton levelButton, float gemValue)
    {
        levelButton.gemValue = gemValue;
    }
    public void ButtonValueCoin(LevelButton levelButton, float coinValue)
    {
        levelButton.coinValue = coinValue;
    }
    public void ButtonValuePot(LevelButton levelButton, float potValue)
    {
        levelButton.potValue = potValue;
    }
    
}
