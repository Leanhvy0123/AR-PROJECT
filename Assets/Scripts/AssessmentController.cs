using UnityEngine;
using UnityEngine.SceneManagement; 

public class AssessmentController : MonoBehaviour
{
    // Kéo các Panel từ Hierarchy vào đây trong Inspector
    public GameObject panelIntro;
    public GameObject panelLanguage;
    public GameObject panelLevel;

    // Chuyển từ Intro sang chọn Ngôn ngữ
    public void GoToLanguage()
    {
        panelIntro.SetActive(false);
        panelLanguage.SetActive(true);
    }

    // Chuyển từ Ngôn ngữ sang chọn Trình độ
    public void GoToLevel()
    {
        panelLanguage.SetActive(false);
        panelLevel.SetActive(true);
    }

    // Kết thúc và chuyển sang màn hình Adventure Map
    public void FinishAssessment()
    {
        // Phải đảm bảo bạn đã tạo Scene tên là 03_Home
        SceneManager.LoadScene("03_Home"); 
    }
}