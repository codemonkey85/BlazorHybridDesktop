namespace BlazorHybridDesktop
{
    public partial class Main
    {

        private string LabelTitle { get; set; } = "Hello, World!";

        private bool ShowWeb { get; set; } = false;


        private void CheckboxClicked(bool isChecked)
        {
            ShowWeb = isChecked;
            StateHasChanged();
        }
    }
}
