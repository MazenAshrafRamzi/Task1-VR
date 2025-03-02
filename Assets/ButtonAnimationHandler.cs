using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ToggleButton : MonoBehaviour
{
    public bool isToggled = false;

    private XRSimpleInteractable interactable;
    private bool isInteracting = false;

    private void Start()
    {
        interactable = GetComponent<XRSimpleInteractable>();

        interactable.selectEntered.AddListener(_ => StartInteraction());
        interactable.selectExited.AddListener(_ => EndInteraction());
    }

    private void StartInteraction()
    {
        isInteracting = true;
    }

    private void EndInteraction()
    {
        if (isInteracting)
        {
            ToggleState();
            isInteracting = false;
        }
    }

    public void ToggleState()
    {
        isToggled = !isToggled;
        Debug.Log($"Button Toggled: {isToggled}");

    }
}