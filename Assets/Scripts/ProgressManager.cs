using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressManager : MonoBehaviour
{
    public Image progressCircle; // Kéo Progress_Fill vào đây
    public TextMeshProUGUI percentText; // Kéo chữ % vào đây
    
    private float currentProgress = 0f; // 0f là 0%, 1f là 100%

    void Start()
    {
        // Lấy dữ liệu cũ đã lưu, nếu chưa có thì mặc định là 0
        currentProgress = PlayerPrefs.GetFloat("SavedProgress", 0f);
        UpdateUI();
    }

    // Hàm này sẽ được gọi mỗi khi nhấn nút AR
    public void IncreaseProgress()
    {
        if (currentProgress < 1f) 
        {
            currentProgress += 0.01f; // Tăng thêm 1%
            if (currentProgress > 1f) currentProgress = 1f; // Không quá 100%

            // Lưu lại để tắt app mở lại không bị mất
            PlayerPrefs.SetFloat("SavedProgress", currentProgress);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        progressCircle.fillAmount = currentProgress;
        percentText.text = Mathf.FloorToInt(currentProgress * 100).ToString();
    }
}