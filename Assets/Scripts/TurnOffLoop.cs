using UnityEngine;

public class TurnOffLoop : MonoBehaviour
{
    void Start()
    {
        AudioSource[] sources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in sources)
        {
            a.loop = false;
        }

        Debug.Log("Đã tắt loop toàn bộ audio");
    }
}