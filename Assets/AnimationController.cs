using UnityEngine;

public class AnimationToggle : MonoBehaviour
{
    public ToggleButton toggleButton;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        if (toggleButton != null)
        {
            // Initialize animation state
            animator.SetBool("PlayAnimation", toggleButton.isToggled);
        }
    }

    private void Update()
    {
        if (toggleButton != null && animator != null)
        {
            animator.SetBool("PlayAnimation", toggleButton.isToggled);
        }
    }
}