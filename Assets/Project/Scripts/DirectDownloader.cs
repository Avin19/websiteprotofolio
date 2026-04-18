using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class DirectDownloader : MonoBehaviour
{
    private string directDownloadUrl = "https://drive.google.com/uc?export=download&id=";
    [SerializeField] private string resumeFileID = "1st2yBYvXjuUaU8ZFi4HlJ9Dkzh3rKfKO";

    public void OnDownloadButtonClicked()
    {
        Application.OpenURL("https://drive.google.com/file/d/1st2yBYvXjuUaU8ZFi4HlJ9Dkzh3rKfKO/view?usp=sharing");

        // StartCoroutine(DownloadFile());
    }

    private IEnumerator DownloadFile()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(directDownloadUrl + resumeFileID))
        {
            UnityWebRequestAsyncOperation operation = request.SendWebRequest();
            while (!operation.isDone)
            {
                // Optional: Update a progress bar
                // Debug.Log($"Downloaded {request.downloadHandler.progress * 100f}%");
                yield return null;
            }

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError($"Download failed: {request.error}");
            }
            else
            {
                // The file data is now in request.downloadHandler.data (a byte array)
                byte[] fileData = request.downloadHandler.data;
                Debug.Log($"Download successful! Size: {fileData.Length} bytes");
                // Process the fileData (e.g., create a Texture2D, parse JSON, etc.)
            }
        }
    }
}