// Hanndle level loading (What trigger to load level)

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{
    public int sceneIndex; // The index of the scene switch to

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
