using UnityEngine;
using UnityEngine.UI;

public class CameraToggle : MonoBehaviour
{
    public Camera secondCamera;
    public KeyCode toggleKey = KeyCode.Return;
    public GameObject smallWindow;
    private bool isSmallWindowActive = false;

    void Start()
    {
        // Ensure the small window is initially inactive
        smallWindow.SetActive(false);
    }

    void Update()
    {
        // Toggle small window visibility on key press
        if (Input.GetKeyDown(toggleKey))
        {
            isSmallWindowActive = !isSmallWindowActive;
            smallWindow.SetActive(isSmallWindowActive);
        }
    }

    void LateUpdate()
    {
        // Update the small window's RawImage texture with the second camera's render texture
        if (isSmallWindowActive)
        {
            RenderTexture renderTexture = secondCamera.targetTexture;
            if (renderTexture != null)
            {
                Texture2D tex = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
                RenderTexture.active = renderTexture;
                tex.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
                tex.Apply();
                RenderTexture.active = null;

                // Assign the texture to the RawImage component
                smallWindow.GetComponent<RawImage>().texture = tex;
            }
        }
    }
}
