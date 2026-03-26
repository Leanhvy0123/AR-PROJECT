using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này để chuyển Scene

public class NavigationManager : MonoBehaviour
{
    [Header("Các Khung Giao Diện (Panel)")]
    public GameObject panelHome;
    public GameObject panelLibrary;
    public GameObject panelProfile;

    // 1. Hàm chuyển sang Scene AR (Nút chính giữa)
    public void GoToARScene()
    {
        // "04_AR" phải trùng tên chính xác với tên Scene AR của bạn
        SceneManager.LoadScene("04_AR"); 
    }

    // 2. Các hàm bật/tắt Panel cho thanh Navigation Bar
    public void ShowHome()
    {
        panelHome.SetActive(true);
        panelLibrary.SetActive(false);
        panelProfile.SetActive(false);
    }

    public void ShowLibrary()
    {
        panelHome.SetActive(false);
        panelLibrary.SetActive(true);
        panelProfile.SetActive(false);
    }

    public void ShowProfile()
    {
        panelHome.SetActive(false);
        panelLibrary.SetActive(false);
        panelProfile.SetActive(true);
    }
}