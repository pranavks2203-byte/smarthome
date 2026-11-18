using System.Collections.Generic;
using UnityEngine;

public class WasherZone : MonoBehaviour
{
    private List<Garment> itemsInWasher = new List<Garment>();

    private void OnTriggerEnter(Collider other)
    {
        Garment item = other.GetComponent<Garment>();
        if (item != null)
        {
            item.currentStatus = "Washer";
            if (!itemsInWasher.Contains(item))
            {
                itemsInWasher.Add(item);
                Debug.Log($"🫧 [WASHER EVENT]: Loaded {item.garmentName} into the washing machine.");
            }

            // Run safety evaluation
            DigitalTwinManager.Instance.CheckWashingMachineSafety(itemsInWasher);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Garment item = other.GetComponent<Garment>();
        if (item != null && itemsInWasher.Contains(item))
        {
            itemsInWasher.Remove(item);
            Debug.Log($"🫧 [WASHER EVENT]: Unloaded {item.garmentName} from washing machine.");
        }
    }
}