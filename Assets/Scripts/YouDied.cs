
using UnityEngine;

public class YouDied : MonoBehaviour
{
    public TMPro.TextMeshProUGUI UITextMeshPro;
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            UITextMeshPro.enabled = true;
            movement.enabled = false;
        }
    }
}
