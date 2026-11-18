using UnityEngine;

public class Garment : MonoBehaviour
{
    [Header("Garment Metadata")]
    public string garmentID;
    public string garmentName;
    public string color;        // e.g., "White", "Black", "Red", "Light"
    public string material;     // e.g., "Cotton", "Denim", "Silk", "Wool"
    
    [Header("Live Status")]
    public string currentStatus = "Closet"; // "Closet", "Wearing", "Basket", "Washer"
}