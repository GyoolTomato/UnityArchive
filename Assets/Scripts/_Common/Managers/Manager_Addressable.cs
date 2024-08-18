using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class Manager_Addressable
{
    //
    public static AssetReference SpawnablePrefab;


    /// <summary>
    /// 
    /// </summary>
    public static void Init()
    {
        LoadAssetAsync("Panel_Students");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key"></param>
    public static void DownloadDependenciesAsync(object key)
    {
        Addressables.GetDownloadSizeAsync(key).Completed += (opSize)=>
        {
            if (opSize.Status == AsyncOperationStatus.Succeeded && opSize.Result > 0)
            {
                Addressables.DownloadDependenciesAsync(key, true).Completed += (opDownload) =>
                {
                    if (opDownload.Status != AsyncOperationStatus.Succeeded)
                        return;
                };
            }
            else
            {
                
            }
        };
    }

    /// <summary>
    /// 
    /// </summary>
    public static void LoadAssetAsync(object key)
    {
        try
        {
            Addressables.LoadAssetAsync<GameObject>(key).Completed += (op) =>
            {
                //
                if (op.Status != AsyncOperationStatus.Succeeded)
                 return;
                
                //
                
            };
        }
        catch (Exception ex)
        {
            Debug.LogError(ex.Message);
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public static void CreatePrefab()
    {
        List<AsyncOperationHandle<GameObject>> handles = new List<AsyncOperationHandle<GameObject>>();

        AsyncOperationHandle<GameObject> handle = SpawnablePrefab.InstantiateAsync();
        handles.Add(handle);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void AssetDestruct(GameObject gameObject)
    {
        //
        Addressables.ReleaseInstance(gameObject);
    }
}
