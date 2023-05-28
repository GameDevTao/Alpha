using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssetBundleSystem;
using System;

/// <summary>
/// �YԴ������
/// </summary>
public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;

    private AssetBundleManager m_AssetBundleManager;
    private void Awake()
    {
        Instance = this;

        m_AssetBundleManager = gameObject.AddComponent<AssetBundleManager>();
    }

    /// <summary>
    /// �첽������Դ(GC�ͷ�)
    /// </summary>
    public void AsyncLoadAssetAuto(string path, Action<AssetBundleInfo> onComplete)
    {
        AssetBundleManager.Instance.Load(path, (AssetBundleInfo abInfo) =>
        {
            onComplete(abInfo);
        });
    }

    /// <summary>
    /// ͬ��������Դ
    /// </summary>
    public void SyncLoadAssetAuto(string path, Action<AssetBundleInfo> onCompleteCallback)
    {
        //todo:
    }

    /// <summary>
    /// ͬ��������Դ
    /// </summary>
    public int SyncLoadAssetManual(string path, Action<AssetBundleInfo> onCompleteCallback)
    {
        //todo:
        return 0;
    }

    /// <summary>
    /// �첽������Դ(Manual�ͷ�)
    /// </summary>
    public int AsyncLoadAssetManual(string path, Action<AssetBundleInfo> onComplete)
    {
        //todo:
        return 0;
    }

    /// <summary>
    /// �ֶ��ͷ���Դ
    /// </summary>
    public void ReleaseAsset(int assetId)
    {
    }
}
