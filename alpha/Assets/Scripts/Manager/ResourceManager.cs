using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssetBundleSystem;
using System;

/// <summary>
/// 資源管理器
/// </summary>
[RegisterSystem]
public class ResourceManager : SystemBase<ResourceManager>
{
    public override void OnInit()
    {
    }

    public override void OnReset()
    {
    }

    /// <summary>
    /// 异步加载资源(GC释放)
    /// </summary>
    public void AsyncLoadAssetAuto(string path, Action<AssetBundleInfo> onComplete)
    {
        AssetBundleManager.Instance.Load(path, (AssetBundleInfo abInfo) =>
        {
            onComplete(abInfo);
        });
    }

    /// <summary>
    /// 同步加载资源
    /// </summary>
    public void SyncLoadAssetAuto(string path, Action<AssetBundleInfo> onCompleteCallback)
    {
        //todo:
    }

    /// <summary>
    /// 同步加载资源
    /// </summary>
    public int SyncLoadAssetManual(string path, Action<AssetBundleInfo> onCompleteCallback)
    {
        //todo:
        return 0;
    }

    /// <summary>
    /// 异步加载资源(Manual释放)
    /// </summary>
    public int AsyncLoadAssetManual(string path, Action<AssetBundleInfo> onComplete)
    {
        //todo:
        return 0;
    }

    /// <summary>
    /// 手动释放资源
    /// </summary>
    public void ReleaseAsset(int assetId)
    {
    }
}
