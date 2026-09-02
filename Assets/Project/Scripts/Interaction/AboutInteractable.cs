using UnityEngine;

public class AboutInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private PortfolioUIManager uiManager;

    public void Interact()
    {
        if (uiManager != null)
        {
            uiManager.OpenAboutPanel();
        }
    }
}