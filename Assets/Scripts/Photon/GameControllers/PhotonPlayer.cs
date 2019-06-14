using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PhotonPlayer : MonoBehaviour
{
    private PhotonView view;
    public GameObject myAvatar;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        int spawnPicker = Random.Range(0, GameSetup.setup.spawnPoints.Length);
        if (view.IsMine)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerAvatar"),
                GameSetup.setup.spawnPoints[spawnPicker].position,
                GameSetup.setup.spawnPoints[spawnPicker].rotation, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
