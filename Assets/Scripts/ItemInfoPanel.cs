using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoPanel : MonoBehaviour
{
   public static ItemInfoPanel Instance;

   public Text itemName;
   public Text itemDescription;
   public Text itemStats;
   public Text coin;
   public Text Rarity;
   public Text weight;
   public Image icon;

   private ItemsBase currentItem;

   protected bool isActive;

   private void Awake()
   {
    Instance = this;
    gameObject.SetActive(false);
   }

   public void DisplayItemInfo(ItemsBase item)
   {
    itemName.text = item.Name;
    itemDescription.text = item.Description;
    icon.sprite = item.Icon;
    weight.text = $"Weight: {item.generalStats.Weight.ToString()}";
    coin.text = $"Value: {item.generalStats.Value.ToString()}";
    Rarity.text = item.generalStats.rarity.ToString();

    displayItemStats(item);
    setActivePanel(item);
    currentItem = item;
   }

    private void displayItemStats(ItemsBase item)
    {
        switch(item.type)
        {
            case ItemTypes.Consumables:
                var consumable = item as ConsumableItems;
                itemStats.text = $"Health Restored: {consumable.consumablesStats.healthRestore}\n Hunger Restored: {consumable.consumablesStats.hungerRestore}\n Mana Restored: {consumable.consumablesStats.manaRestore}";
                break;
            case ItemTypes.Armor:
                var armor = item as ArmorItems;
                itemStats.text = $"Efficacy: {armor.ArmorStats.efficacy}\n Health Gain:{armor.ArmorStats.Health}\n Magic Resistance: {armor.ArmorStats.magic_resist}\n Durability:{armor.ArmorStats.durability}";
                break;
            case ItemTypes.Weapons:
                var weapon = item as WeaponItems;
                itemStats.text = $"Damage: {weapon.weaponStats.damage}\n Magic Damage:{weapon.weaponStats.magicDamage}\n Attack Speed:{weapon.weaponStats.attackSpeed}\n Durability:{weapon.weaponStats.durability}";
                break;
            case ItemTypes.Materials:
                itemStats.text = "";
                break;
            case ItemTypes.Tools:
                var tool = item as ToolItems;
                itemStats.text = $"Damage:{tool.toolStats.damage}\n Durability{tool.toolStats.durability}";
                break;
            case ItemTypes.Miscellanous:
                itemStats.text = "";
                break;
        
        }
    }

    public void setActivePanel(ItemsBase item)
   {
    if(isActive && item == currentItem)
    {
        gameObject.SetActive(false);
        isActive = false;
    }
    else
    {
        gameObject.SetActive(true);
        isActive = true;
    }
   }
}
