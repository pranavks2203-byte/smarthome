using System.Collections.Generic;
using UnityEngine;

public class DigitalTwinManager : MonoBehaviour
{
    public static DigitalTwinManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void CheckWashingMachineSafety(List<Garment> garmentsInWasher)
    {
        if (garmentsInWasher.Count <= 1) return;

        bool hasWhites = false;
        bool hasDarksOrReds = false;
        bool hasDelicates = false;
        bool hasHeavy = false;

        foreach (var item in garmentsInWasher)
        {
            string c = item.color.ToLower();
            string m = item.material.ToLower();

            if (c == "white" || c == "light" || c == "beige") hasWhites = true;
            if (c == "black" || c == "red" || c == "dark" || c == "blue") hasDarksOrReds = true;

            if (m == "silk" || m == "wool" || m == "delicate") hasDelicates = true;
            if (m == "denim" || m == "canvas" || m == "heavy cotton") hasHeavy = true;
        }

        // Color check warning
        if (hasWhites && hasDarksOrReds)
        {
            Debug.LogWarning("⚠️ [WASHING MACHINE WARNING]: Mixing White/Light clothes with Dark/Red clothes!");
        }

        // Material check warning
        if (hasDelicates && hasHeavy)
        {
            Debug.LogWarning("⚠️ [WASHING MACHINE WARNING]: Mixing Delicate fabrics (Silk/Wool) with Heavy fabrics (Denim)!");
        }
    }
}