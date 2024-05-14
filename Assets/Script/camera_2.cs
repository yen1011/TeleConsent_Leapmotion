using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera_2 : MonoBehaviour
{
    WebCamTexture webcam;
    public RawImage img;

    void Start()
    {
        // 기본 카메라 설정을 위해 ChangeCamera 메서드 호출
        // 여기서는 첫 번째 카메라(0번 인덱스)를 기본값으로 설정합니다.
        ChangeCamera(0);
    }

    // 카메라를 전환하는 메서드
    public void ChangeCamera(int cameraIndex)
    {
        // 연결된 카메라 목록을 가져옵니다.
        WebCamDevice[] devices = WebCamTexture.devices;

        // 선택된 카메라 인덱스가 연결된 카메라의 수보다 적은지 확인합니다.
        if (cameraIndex >= 0 && cameraIndex < devices.Length)
        {
            // 현재 실행 중인 카메라가 있으면 정지합니다.
            if (webcam != null)
            {
                webcam.Stop();
            }

            // 새로운 카메라 선택하여 재생
            webcam = new WebCamTexture(devices[cameraIndex].name);
            img.texture = webcam;
            webcam.Play();
        }
        else
        {
            Debug.Log("Selected camera index is out of range.");
        }
    }
}
