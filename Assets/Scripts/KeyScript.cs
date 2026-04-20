using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject doorCollider;

    void Start()
    {
        doorCollider.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorCollider.SetActive(false);
            Destroy(gameObject);
        }
    }
    
}
