using System;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CompendiumManager : MonoBehaviour
{
    public Transform gridparent;
    public GameObject slotprefab;
    public TMP_InputField searchBar;
    public string textSearch;

    public ItemTypes currentType = ItemTypes.All;
    public ItemsBase[] items;
    

    void Start()
    {
        if(searchBar != null)
        {
            searchBar.onValueChanged.AddListener(OnSearchChanged);
        }
        items = Resources.LoadAll<ItemsBase>("Items");
        DisplayItems();
    }



    private void OnSearchChanged(string searchText)
    {
        if(string.IsNullOrEmpty(searchText))
        {
            textSearch = null;
            UpdateDisplayItem();
        }
        else
        {
            textSearch = searchText;
            UpdateDisplayItem();
        }
    }

    private void UpdateDisplayItem()
    {
        switch(currentType)
        {
            case ItemTypes.All:
                DisplayAllItem();
                break;
            case ItemTypes.Consumables:
                DisplayConsumableItem();
                break;
            case ItemTypes.Armor:
                DisplayArmorItem();
                break;
            case ItemTypes.Weapons:
                DisplayWeaponItem();
                break;
            case ItemTypes.Materials:
                DisplayMaterialItem();
                break;
            case ItemTypes.Tools:
                DisplayToolItem();
                break;
            case ItemTypes.Miscellanous:
                DisplayMiscellanousItem();
                break;
        }
    }

    private void clearDisplayItems()
    {
        foreach (Transform child in gridparent)
        {
            Destroy(child.gameObject);
        }
    }
    private void DisplayItems()
    {
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(textSearch == null)
            {
            var slot = Instantiate(slotprefab, gridparent);
            slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else
            {
                if(item.name.ToLower().Contains(textSearch))
                {
                    var slot = Instantiate(slotprefab, gridparent);
                    slot.GetComponent<ItemSlot>().SetItem(item);
                }
            }
        }
    }

    public void DisplayAllItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.All;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(textSearch == null)
            {
            var slot = Instantiate(slotprefab, gridparent);
            slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else
            {
                if(item.name.ToLower().Contains(textSearch))
                {
                    var slot = Instantiate(slotprefab, gridparent);
                    slot.GetComponent<ItemSlot>().SetItem(item);
                }
            }
        }
    }

    public void DisplayConsumableItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.Consumables;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(item.type == ItemTypes.Consumables && textSearch == null)
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else if(item.type == ItemTypes.Consumables && item.name.ToLower().Contains(textSearch))
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
        }
    }



    public void DisplayArmorItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.Armor;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(item.type == ItemTypes.Armor && textSearch == null)
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else if (item.type == ItemTypes.Armor && item.name.ToLower().Contains(textSearch))
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
        }
    }

    public void DisplayWeaponItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.Weapons;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(item.type == ItemTypes.Weapons && textSearch == null)
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else if (item.type == ItemTypes.Weapons && item.name.ToLower().Contains(textSearch))
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
        }
    }

    public void DisplayMaterialItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.Materials;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(item.type == ItemTypes.Materials && textSearch == null)
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else if (item.type == ItemTypes.Materials && item.name.ToLower().Contains(textSearch))
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
        }
    }

    public void DisplayToolItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.Tools;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(item.type == ItemTypes.Tools && textSearch == null)
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else if (item.type == ItemTypes.Tools && item.name.ToLower().Contains(textSearch))
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
        }
    }

    public void DisplayMiscellanousItem()
    {
        clearDisplayItems();
        currentType = ItemTypes.Miscellanous;
        var sortedItems = items.OrderBy(item => item.Name).ToArray();

        foreach (var item in sortedItems)
        {
            if(item.type == ItemTypes.Miscellanous && textSearch == null)
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
            else if (item.type == ItemTypes.Miscellanous && item.name.ToLower().Contains(textSearch))
            {
                var slot = Instantiate(slotprefab, gridparent);
                slot.GetComponent<ItemSlot>().SetItem(item);
            }
        }
    }
}
