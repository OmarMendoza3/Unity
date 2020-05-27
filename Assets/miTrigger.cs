
using UnityEngine;

public class mytrigger : MonoBehaviour
{
    public GameObject spotlight;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("OnTriggerEnter");
        spotlight.SetActive(true);
    }

}
