using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public static NetworkManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Instance already exists. Destroying object...");
            Destroy(this);
        }
    }

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
        Server.Start(50, 26950);
    }

    public void OnApplicationQuit()
    {
        Server.Stop();
    }

    public Player InitializePlayer()
    {
        return Instantiate(playerPrefab, new Vector3(7, 0, 0), Quaternion.identity).GetComponent<Player>();
    }
}
