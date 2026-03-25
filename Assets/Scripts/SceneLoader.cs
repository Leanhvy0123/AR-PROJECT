using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện để chuyển cảnh

public class SceneLoader : MonoBehaviour
{
    public void StartApp()
    {
        // Nó sẽ chuyển sang Scene tiếp theo có tên là 02_LevelAssessment
        SceneManager.LoadScene("02_LevelAssessment");
    }
}