using System;

delegate void ButtonClickHandler();

class Button
{
    public event ButtonClickHandler? OnClick;

    public static void Mainn(string[] args)
    {
        Button button = new Button();
        button.OnClick += () => Console.WriteLine("Button Clicked!");
        button.Click();
    }

    public void Click()
    {
        OnClick?.Invoke();
    }
}
