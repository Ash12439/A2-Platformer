using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    public int numberCollected;

    public void PickupTriggered()
    {
        numberCollected += 1;
    }
}