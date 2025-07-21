using UnityEngine;
using System.IO;

public class NumDisplay : MonoBehaviour
{
    [Tooltip("Training Image Folder")]
    public string imageFolder = "Images/Training";

    [Tooltip("Number Index")]
    public int imageIndex = 0;

    private Texture2D[] textures;
    private Renderer planeRenderer;

    void Start()
    {
        planeRenderer = GetComponent<Renderer>();
        LoadTextures();
    }

    void LoadTextures()
    {
        textures = Resources.LoadAll<Texture2D>(imageFolder);
    }

    [ContextMenu("Display Random Image")]
    void DisplayRandomImage()
    {
        int randomIndex = Random.Range(0, textures.Length);
        planeRenderer.material.mainTexture = textures[randomIndex];
    }

    [ContextMenu("Display Image by Index")]
    void DisplayImageByIndex()
    {
        planeRenderer.material.mainTexture = textures[imageIndex];
    }
}