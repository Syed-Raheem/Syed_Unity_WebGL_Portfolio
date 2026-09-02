using UnityEngine;

public class PortfolioUIManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private GameObject aboutPanel;

    [Header("Player")]
    [SerializeField] private FirstPersonController playerController;

    private bool isPanelOpen;

    private void Start()
    {
        if (aboutPanel != null)
        {
            aboutPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (isPanelOpen && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseAboutPanel();
        }
    }

    public void OpenAboutPanel()
    {
        if (aboutPanel == null)
            return;

        aboutPanel.SetActive(true);

        isPanelOpen = true;

        DisablePlayerControl();

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseAboutPanel()
    {
        if (aboutPanel == null)
            return;

        aboutPanel.SetActive(false);

        isPanelOpen = false;

        EnablePlayerControl();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void DisablePlayerControl()
    {
        if (playerController != null)
        {
            playerController.enabled = false;
        }
    }

    private void EnablePlayerControl()
    {
        if (playerController != null)
        {
            playerController.enabled = true;
        }
    }

    public bool IsPanelOpen()
    {
        return isPanelOpen;
    }
}