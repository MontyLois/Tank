using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
    {
        public GameObject pauseMenuUI;
        private bool isPaused = false;

        void Start()
        {
            Cursor.visible = false; 
            pauseMenuUI.SetActive(false); // Assurez-vous que le menu de pause est désactivé au démarrage
            isPaused = false;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (isPaused)
                {
                    ResumeGame();
                }
                else
                {
                    Pause();
                }
            }
        }

       
        public void ResumeGame()
        {
            Debug.Log("bah alors ça resume pas ? ");
            Cursor.visible = false; 
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f; // Reprend le temps normal
            isPaused = false;
        }
        
        public void ReloadGame()
        {
            SceneManager.LoadScene("Lvl1");
        }

        public void Pause()
        {
            Cursor.visible = true; 
            Time.timeScale = 0f; // Arrête le temps dans le jeu
            pauseMenuUI.SetActive(true);
            isPaused = true;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
