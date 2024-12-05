using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ConsumableItems", menuName = "Scriptable Objects/ConsumableItems")]
public class ConsumableItems : ItemsBase
{
    [SerializeField] private ConsumablesStats _cons_stats;
    public ConsumablesStats consumablesStats => _cons_stats;
}
[Serializable]
public struct ConsumablesStats
{
    public float hungerRestore;
    public float healthRestore;
    public float manaRestore;
}
