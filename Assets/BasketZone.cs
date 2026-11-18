using UnityEngine;

public class BasketZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Garment item = other.GetComponent<Garment>();
        if (item != null)
        {
            if (item.currentStatus != "Basket")
            {
                item.currentStatus = "Basket";
                Debug.Log($"🧺 [BASKET EVENT]: Placed {item.garmentName} into the basket.");
            }
        }
    }
}