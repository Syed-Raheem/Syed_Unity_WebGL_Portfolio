using UnityEngine;

public class SimpleInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string objectName = "Interactable";

    public void Interact()
    {
        Debug.Log("Interacted with: " + objectName);
    }
}