using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName ="Card/attaks")]//lo segundo es para hacer grupos
public class Card : ScriptableObject
{
    public string cardName,descrption,cost;
    public Sprite artwork;
}
