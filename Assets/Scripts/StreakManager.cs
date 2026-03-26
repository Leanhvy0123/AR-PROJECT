using UnityEngine;
using TMPro;
using System;

public class StreakManager : MonoBehaviour
{
    public TextMeshProUGUI streakText;
    private int currentStreak = 0;

    void Start()
    {
        UpdateStreak();
    }

    void UpdateStreak()
    {
        // Lấy dữ liệu ngày cuối cùng học (Lưu trong máy)
        string lastDateStr = PlayerPrefs.GetString("LastStudyDate", "");
        currentStreak = PlayerPrefs.GetInt("CurrentStreak", 0);

        if (!string.IsNullOrEmpty(lastDateStr))
        {
            DateTime lastDate = DateTime.Parse(lastDateStr);
            TimeSpan difference = DateTime.Now.Date - lastDate.Date;

            if (difference.Days == 1) {
                // Nếu là ngày hôm sau -> Tăng streak
                currentStreak++;
            } else if (difference.Days > 1) {
                // Nếu bỏ lỡ > 1 ngày -> Về 0 (Khóc nhẹ)
                currentStreak = 0;
            }
        }
        else {
            currentStreak = 1; // Lần đầu tiên mở app
        }

        // Lưu lại ngày hôm nay và số streak mới
        PlayerPrefs.SetString("LastStudyDate", DateTime.Now.ToString());
        PlayerPrefs.SetInt("CurrentStreak", currentStreak);

        // Hiển thị lên màn hình
        streakText.text = currentStreak + " Days Streak Unlocked!";
    }
}