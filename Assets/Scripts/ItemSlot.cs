using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
   public Image icon;
   public Text itemName;
    public AudioClip clickSound;
   [SerializeField]private ItemsBase currentItem;


    

   public void SetItem(ItemsBase item)
   {
    currentItem = item;
    icon.sprite = item.Icon;
    itemName.text = item.Name;
   }

   public void OnClick()
   {
    if(currentItem != null)
    {
        AudioManager.instance.PlaySound(clickSound);
        ItemInfoPanel.Instance.DisplayItemInfo(currentItem);
    }
   }
}
