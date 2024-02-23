using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages;

public partial class Counter : ComponentBase
{
    protected int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
