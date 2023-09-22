using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject itemButtonPrefab;
    public Transform itemButtonParent;

    private Inventory inventory;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();

        foreach (Item item in inventory.items)
        {
            GameObject itemButton = Instantiate(itemButtonPrefab, itemButtonParent);
            
            itemButton.GetComponent<Button>().onClick.AddListener(() => PlaceItem(item));
        }
    }

    public void PlaceItem(Item item)
    {
        // Yerleştirme işlemini burada gerçekleştirin.
        // Örneğin:
        Instantiate(item.prefab, item.position, Quaternion.identity);

        // Eğer objeyi kullanırsanız destroy edin.
        //Destroy(item);

        // Yerleştirme işlemi tamamlandıktan sonra envanterden öğeyi kaldırın.
        
        //inventory.RemoveItem(item);
    }
}