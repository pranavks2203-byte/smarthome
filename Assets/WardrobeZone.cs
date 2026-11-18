using UnityEngine;

public class WardrobeZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Garment item = other.GetComponent<Garment>();
        if (item != null && item.currentStatus != "Closet")
        {
            item.currentStatus = "Closet";
            Debug.Log($"👔 [WARDROBE EVENT]: Stored {item.garmentName}. Status -> CLOSET");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Garment item = other.GetComponent<Garment>();
        if (item != null && item.currentStatus == "Closet")
        {
            item.currentStatus = "Wearing";
            Debug.Log($"👕 [WARDROBE EVENT]: Removed {item.garmentName}. Status -> WEARING");
        }
    }
}