using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Page : MonoBehaviour
{
    public Sprite[] sprites; // ����� Sprite �̹��� �迭
    public Image image; // �̹����� ǥ���� Image ������Ʈ

    private int currentSpriteIndex = 0; // ���� Sprite �̹����� �ε���

    // ���� �̹����� �����ϴ� �Լ�
    public void NextImage()
    {
        currentSpriteIndex++; // ���� �̹��� �ε����� ����

        if (currentSpriteIndex >= sprites.Length) // �̹��� �ε����� �迭�� ������ ��� ���
        {
            currentSpriteIndex = 0; // ù ��° �̹����� ����
        }

        image.sprite = sprites[currentSpriteIndex]; // �̹��� ������Ʈ
    }

    // ���� �̹����� �����ϴ� �Լ�
    public void PrevImage()
    {
        currentSpriteIndex--; // ���� �̹��� �ε����� ����

        if (currentSpriteIndex < 0) // �̹��� �ε����� �迭�� ������ ��� ���
        {
            currentSpriteIndex = sprites.Length - 1; // ������ �̹����� ����
        }

        image.sprite = sprites[currentSpriteIndex]; // �̹��� ������Ʈ
    }
}

