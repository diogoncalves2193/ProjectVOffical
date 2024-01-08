using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMusic : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component

    private void Start()
    {
        // Make sure there is an AudioSource component attached
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found. Please attach an AudioSource component to the GameObject.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the triggering object has the tag "Player" (you can modify this as needed)
        if (other.CompareTag("Player"))
        {
            // Check if the AudioSource is not already playing
            if (!audioSource.isPlaying)
            {
                // Play the audio clip
                audioSource.Play();
            }
        }
    }
}
