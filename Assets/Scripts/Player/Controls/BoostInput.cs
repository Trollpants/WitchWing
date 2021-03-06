// <copyright file="BoostInput.cs" company="Jan Ivar Z. Carlsen, Sindri Jóelsson">
// Copyright (c) 2016 Jan Ivar Z. Carlsen, Sindri Jóelsson. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WitchWing.Player.Controls
{
    using GUI;
    using UnityEngine;
    using UnityEngine.EventSystems;

    [RequireComponent(typeof(NonDrawingGraphic))]
    public class BoostInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public bool IsPressingBoost { get; private set; }

        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
            IsPressingBoost = true;
        }

        void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
            IsPressingBoost = false;
        }
    }
}
