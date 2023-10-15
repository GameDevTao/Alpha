/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System;

namespace FancyScrollView.Example05
{
    class ItemData
    {
        public string Message { get; }
        public Action Callback;

        public ItemData(string message, Action callback = null)
        {
            Message = message;
            Callback = callback;
        }
    }
}
