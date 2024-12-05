using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ArmorItems", menuName = "Scriptable Objects/ArmorItems")]
public class ArmorItems : ItemsBase
{
    [SerializeField] private ArmorStats _armor_stats;
    public ArmorStats ArmorStats => _armor_stats;
}

[Serializable]
public struct ArmorStats
{
    public int Health;
    public int durability;
    public int magic_resist;
    public int efficacy;
}
