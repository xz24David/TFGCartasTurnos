using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName ="Card/Comunes")]//lo segundo es para hacer grupos
public class Card : ScriptableObject
{
    public string cardName,descrption,cost;
    public bool isUpgraded;
    public CardDescription cardDescription;
    public CardAmount cardCost,cardEffect,buffAmount;
    public Sprite artwork;
    public enum CardType { Attack,Skill,Power}
    public CardType cardType;
    public enum CardClass {ironClad, silent, colorless, curse, status }
    public CardClass cardClass;
    public enum CardTargetType {self,enemy};
    public CardTargetType cardTargetType;

    public int GetCardCostAmount()
    {
        if (!isUpgraded)
            return cardCost.baseAmount;
        else
            return cardCost.upgradedAmount;
    }
    public int GetCardEffectAmount()
    {
        if (!isUpgraded)
            return cardEffect.baseAmount;
        else
            return cardEffect.upgradedAmount;
    }
    public string GetCardDescriptionAmount()
    {
        if (!isUpgraded)
            return cardDescription.baseAmount;
        else
            return cardDescription.upgradedAmount;
    }
    public int GetBuffAmount()
    {
        if (!isUpgraded)
            return buffAmount.baseAmount;
        else
            return buffAmount.upgradedAmount;
    }


[System.Serializable]
public struct CardAmount
{
    public int baseAmount;
    public int upgradedAmount;
}
[System.Serializable]
public struct CardDescription
{
    public string baseAmount;
    public string upgradedAmount;
}
[System.Serializable]
public struct CardBuffs
{
    //public Buff.Type buffType;
    public CardAmount buffAmount;
}
}
