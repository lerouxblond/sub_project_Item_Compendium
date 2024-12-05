using System;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponsItems", menuName = "Scriptable Objects/WeaponsItems")]
public class WeaponItems : ItemsBase
{
    [SerializeField] private WeaponStats _weapon_stats;
    public WeaponStats weaponStats => _weapon_stats;
}

[Serializable]
public struct WeaponStats
{
    public int damage;
    public int magicDamage;
    public float attackSpeed;
    public int durability;
    public damageType damageType;
}

[Serializable]
public enum damageType
{
    Lite = 0,
    Medium = 1,
    Heavy = 2
}
