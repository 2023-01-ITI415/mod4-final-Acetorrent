using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TeleportCube"))
        {
            SceneManager.LoadScene("07-Prototype3");
            Debug.Log("Teleported");
        }
    }
}