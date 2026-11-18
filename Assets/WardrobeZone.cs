using UnityEngine;

public class WardrobeZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Garment item = other.GetComponent<Garment>();
        if (item != null)
        {
            // Toggle state between Closet and Wearing
            if (item.currentStatus == "Closet")
            {
                item.currentStatus = "Wearing";
                Debug.Log($"👕 [WARDROBE EVENT]: Removed {item.garmentName}. Status -> WEARING");
            }
            else
            {
                item.currentStatus = "Closet";
                Debug.Log($"👔 [WARDROBE EVENT]: Stored {item.garmentName}. Status -> CLOSET");
            }
        }
    }
}