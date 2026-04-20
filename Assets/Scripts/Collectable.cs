using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableManager manager;

    private void OnTriggerEnter(Collider other)
    {
        manager.PickupTriggered();
        Destroy(gameObject);
    }
}