using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PlayAudio : MonoBehaviour, IPointerClickHandler
{
    public AudioSource audioSource;

    Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.Play();
        StartCoroutine(ClickEffect());
    }

    IEnumerator ClickEffect()
    {
        // nhỏ lại
        transform.localScale = originalScale * 0.8f;
        yield return new WaitForSeconds(0.1f);

        // bật ra
        transform.localScale = originalScale * 1.1f;
        yield return new WaitForSeconds(0.1f);

        // về bình thường
        transform.localScale = originalScale;
    }
}