using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    [SerializeField] private GameObject message; // Assign in Unity Inspector

    public void PlayGame()
    {
        // Play button click sound
        SoundEffectPlayer.instance.PlayButtonClickSound();
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        SoundEffectPlayer.instance.PlayButtonClickSound();
        Application.Quit();
    }

    public void OtherGameClick()
    {
        SoundEffectPlayer.instance.PlayButtonClickSound();
        SceneManager.LoadSceneAsync(2);
    }
}
