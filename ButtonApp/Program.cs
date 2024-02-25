
var button = new Button();
button.Click += Button_Click;

static void Button_Click(object sender, EventArgs e)
{
    Console.WriteLine(e.ToString());
}

button.SimulateClick();

class Button
{
    public delegate void ButtonClick(object sender, EventArgs e);
    private ButtonClick? _click;

    //public event ButtonClick Click;
    public event ButtonClick Click
    {
        add { _click += value; }
        remove { _click -= value; }
    }
    public void SimulateClick()
    {

        _click?.Invoke(this, EventArgs.Empty);
    }
}
