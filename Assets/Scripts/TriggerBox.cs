using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    public GameObject notTriggered;
    public GameObject Triggered;
    public void OnTriggerEnter(Collider other)
    {
        notTriggered.SetActive(true);
        Triggered.SetActive(false);

        if (other.tag == "Player")
        {
            notTriggered.SetActive (false);
            Triggered.SetActive (true);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
