/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace FancyScrollView.Example05
{
    class Example05 : MonoBehaviour
    {
        [SerializeField] ScrollView scrollView = default;
        [SerializeField] Button prevCellButton = default;
        [SerializeField] Button nextCellButton = default;
        [SerializeField] Text selectedItemInfo = default;

        void Start()
        {
            Application.targetFrameRate = 60;
            
            prevCellButton.onClick.AddListener(scrollView.SelectPrevCell);
            nextCellButton.onClick.AddListener(scrollView.SelectNextCell);
            scrollView.OnSelectionChanged(OnSelectionChanged);

            // var items = Enumerable.Range(0, 20)
            //     .Select(i => new ItemData($"Cell {i}"))
            //     .ToList();

            var items = new List<ItemData>();

            for (int i = 0; i < 5; ++i)
            {
                var num = i + 1;
                var itemData = new ItemData($"Level {num}", () =>
                {
                    SceneManager.LoadScene($"Level{num}_New");
                });
                items.Add(itemData);
            }
            scrollView.UpdateData(items);
            scrollView.UpdateSelection(2);
            scrollView.JumpTo(2);
        }

        void OnSelectionChanged(int index)
        {
            //selectedItemInfo.text = $"Selected item info: index {index}";
        }
    }
}
