
Button button = new();
button.Click += ButtonClickedBehavior;
button.Click += OtherButtonClickedBehavior;

// problem 1 with delegates
//button?.Click?.Invoke(button);
//button.Click = null;

button.SimulateClick();

static void OtherButtonClickedBehavior(Button button)
{
    Console.WriteLine("More button clicked");
    Thread.Sleep(2000);
}
static void ButtonClickedBehavior(Button button)
{
    Console.WriteLine("Button clicked");
    Thread.Sleep(2000);
}

class Button
{
    // problem 1 with delegates
    //public ButtonClick? Click;

    // problem 1 solution
    //private ButtonClick? _click;
    //public void AppendToClick(ButtonClick click)
    //{
    //    _click += click;
    //}
    //public void RemoveToClick(ButtonClick click)
    //{
    //    _click -= click;
    //}

    //private event ButtonClick? _click;
    //public event ButtonClick? Click;

    //public event ButtonClick Click
    //{
    //    add { _click += value; }
    //    remove { _click -= value; }
    //}

    public event ButtonClick? Click;

    // is the same as
    //public event ButtonClick Click; // automatic property

    public void SimulateClick()
    {
        Click?.Invoke(this);
    }
}

delegate void ButtonClick(Button button);