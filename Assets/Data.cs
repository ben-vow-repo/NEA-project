using UnityEngine;
using TMPro;
using System;
using System.Numerics;
public class Data
{
    public TMP_Text moneyText;
    public BigInteger money;
    public BigInteger incrementer;
    public Data(TMP_Text textComponent)
    {
        this.moneyText = textComponent;
        this.money = 0;
        this.incrementer = 1;
    }


}