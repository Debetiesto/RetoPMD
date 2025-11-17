using UnityEngine;
using UnityEngine.Video;

public class Creditos : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void ReproducirCreditos()
    {
        videoPlayer.Play();
    }
}
