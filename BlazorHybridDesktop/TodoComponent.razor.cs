using System;
using Microsoft.AspNetCore.Components;
using Xamarin.Essentials;

namespace BlazorHybridDesktop
{
    public partial class TodoComponent
    {
        [Parameter] public Todo Todo { get; set; }

        private void IsCheckedChanged(bool isChecked)
        {
            Todo.Completed = isChecked;
            try
            {
                HapticFeedback.Perform(HapticFeedbackType.Click);
            }
            catch (FeatureNotSupportedException ex)
            {
                Console.WriteLine($"Haptics not supported.{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
            }
            StateHasChanged();
        }
    }
}
