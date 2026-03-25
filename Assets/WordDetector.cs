using UnityEngine;

public class WordDetector : MonoBehaviour
{
    public string wordName;
    public CombineManager manager;

    void OnEnable()
    {
        manager.SetWordState(wordName, true);
    }

    void OnDisable()
    {
        manager.SetWordState(wordName, false);
    }
}