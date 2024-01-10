using UnityEngine;

public class CloseGameOnTrigger : MonoBehaviour
{
    // Set this to the tag of the player GameObject
    public string playerTag = "Player";

    // Called when another collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is the player
        if (other.CompareTag(playerTag))
        {
            // Close the Unity build
            CloseGame();
        }
    }

    // Method to close the Unity build
    private void CloseGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
