using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Page : MonoBehaviour
{
    public Sprite[] sprites; // 사용할 Sprite 이미지 배열
    public Image image; // 이미지를 표시할 Image 컴포넌트

    private int currentSpriteIndex = 0; // 현재 Sprite 이미지의 인덱스

    // 다음 이미지로 변경하는 함수
    public void NextImage()
    {
        currentSpriteIndex++; // 다음 이미지 인덱스로 변경

        if (currentSpriteIndex >= sprites.Length) // 이미지 인덱스가 배열의 범위를 벗어난 경우
        {
            currentSpriteIndex = 0; // 첫 번째 이미지로 변경
        }

        image.sprite = sprites[currentSpriteIndex]; // 이미지 업데이트
    }

    // 이전 이미지로 변경하는 함수
    public void PrevImage()
    {
        currentSpriteIndex--; // 이전 이미지 인덱스로 변경

        if (currentSpriteIndex < 0) // 이미지 인덱스가 배열의 범위를 벗어난 경우
        {
            currentSpriteIndex = sprites.Length - 1; // 마지막 이미지로 변경
        }

        image.sprite = sprites[currentSpriteIndex]; // 이미지 업데이트
    }
}

