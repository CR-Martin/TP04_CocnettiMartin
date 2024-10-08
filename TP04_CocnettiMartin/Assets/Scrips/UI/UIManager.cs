using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject optionsMenuUI;

    [SerializeField] Slider backgroundMusicVolume;

    [SerializeField] Slider effectVolume;

    private void OnEnable()
    {
        PlayerLife.OnGameOver += GameOver;
    }


    private void OnDisable()
    {
        PlayerLife.OnGameOver -= GameOver;
    }

    void Awake()
    {
        SetTimeToZero();
    }

    void Start()
    {
        AudioManager.Instance.PlayMusic("Main Music");
        backgroundMusicVolume.onValueChanged.AddListener(OnChangeMusicVolume);
        effectVolume.onValueChanged.AddListener(OnChangeEffectVolume);
    }

    private void OnChangeMusicVolume(float volume)
    {
        AudioManager.Instance.MusicVolume(volume);
    }
    private void OnChangeEffectVolume(float volume)
    {
        Debug.Log("Efect volume: " + volume);

    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    private void SetTimeToZero()
    {
        Time.timeScale = 0;
    }

    public void SetTimeToOne()
    {
        Time.timeScale = 1;
        mainMenuUI.SetActive(false);
    }

    public void Reload()
    {
        Debug.Log("Relaod?");
        SceneManager.LoadScene("SampleScene");

    }

    private void GameOver()
    {
        gameOverUI.SetActive(true);
        SetTimeToZero();
    }
}
