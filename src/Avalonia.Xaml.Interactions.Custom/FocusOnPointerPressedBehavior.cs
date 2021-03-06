﻿using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Xaml.Interactivity;

namespace Avalonia.Xaml.Interactions.Custom
{
    /// <summary>
    /// Focuses the <see cref="Behavior{T}.AssociatedObject"/> on <see cref="InputElement.PointerPressed"/> event.
    /// </summary>
    public sealed class FocusOnPointerPressedBehavior : Behavior<Control>
    {
        /// <summary>
        /// Called after the behavior is attached to the <see cref="Behavior.AssociatedObject"/>.
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            if (AssociatedObject is { })
            {
                AssociatedObject.PointerPressed += PointerPressed; 
            }
        }

        /// <summary>
        /// Called when the behavior is being detached from its <see cref="Behavior.AssociatedObject"/>.
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            if (AssociatedObject is { })
            {
                AssociatedObject.PointerPressed -= PointerPressed; 
            }
        }

        private void PointerPressed(object? sender, PointerPressedEventArgs e)
        {
            AssociatedObject?.Focus();
        }
    }
}
