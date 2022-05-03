using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Card", order = 0)]

public class CardCreator : ScriptableObject
{
    public int motivation;
    public int happiness;
    public int stress;
    public int food;
    public int rest;
    public bool passive;
    public string cardName;
    public Sprite image;
}