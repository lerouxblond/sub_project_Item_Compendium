using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ToolItems", menuName = "Scriptable Objects/ToolItems")]
public class ToolItems : ItemsBase
{
    [SerializeField] private toolStats _tool_stats;
    public toolStats toolStats => _tool_stats;
}

[Serializable]
public struct toolStats
{
    public int damage;
    public int durability;
}
