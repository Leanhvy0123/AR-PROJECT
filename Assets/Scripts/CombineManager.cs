using UnityEngine;

public class CombineManager : MonoBehaviour
{
    // Kéo object FOOTBALL_RESULT vào đây trong Inspector
    public GameObject footballObject;

    // Biến kiểm tra trạng thái
    private bool isFootDetected = false;
    private bool isBallDetected = false;

    // Hàm này sẽ được gọi từ WordDetector
    public void SetWordState(string word, bool state)
    {
        if (word == "FOOT")
        {
            isFootDetected = state;
        }

        if (word == "BALL")
        {
            isBallDetected = state;
        }

        CheckCombine();
    }

    // Kiểm tra điều kiện ghép
    void CheckCombine()
    {
        if (isFootDetected && isBallDetected)
        {
            // Nếu cả 2 đều đang scan → hiện FOOTBALL
            footballObject.SetActive(true);
        }
        else
        {
            // Nếu thiếu 1 trong 2 → ẩn đi
            footballObject.SetActive(false);
        }
    }
}