using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public string description;
    public float price;
    public GameObject prefab; // Eşyayı yerleştirmek için prefab
    public Vector3 position; // Ekrana yerleştirilecek pozisyon
}