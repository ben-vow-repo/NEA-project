using UnityEngine;
using TMPro;

public class Control : MonoBehaviour
{
    public TMP_Text moneyTextDisplay;
    private Data gameData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameData = new Data(moneyTextDisplay);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney()
    {
        gameData.money += gameData.incrementer;
        updateUi();
    }
    public void updateUi()
    {
        gameData.moneyText.text = "Clicks - " + gameData.money.ToString();
    }


}
