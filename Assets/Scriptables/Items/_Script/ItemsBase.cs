using System;
using UnityEngine;


[CreateAssetMenu(fileName = "Items", menuName = "Scriptable Objects/Items")]
public class ItemsBase : ScriptableObject
{
    [Header("Item Type")]
    public ItemTypes type;

    [Header("Item Description")]
    public string Name;
    public string Description;

    [Header("Visual")]
    public Sprite Icon;
    
    [Header("General stats")]
    [SerializeField] private GeneralStats _stats;
    public GeneralStats generalStats => _stats;
}

[Serializable]
public struct GeneralStats
{
    public float Weight;
    public int Value;
    public Rarity rarity;
}

[Serializable]
public enum ItemTypes
{
    Consumables = 0,
    Weapons = 1,
    Armor = 2,
    Materials = 3,
    Tools = 4,
    Miscellanous = 5,
    All = 6
}

[Serializable]
public enum Rarity
{
    Common = 0,
    Rare = 1,
    Epic = 2,
    Legendary = 3,
    Undefinded = 4
}