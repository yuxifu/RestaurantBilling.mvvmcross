using Android.Widget;

public class LinkerIncludePlease
{
	private void IncludeClicked(Button button)
	{
        button.Click += (s, e) => { };
	}

	private void IncludeEnabled(Button button)
	{
		button.Enabled = !button.Enabled;
	}

    private void IncludeText(TextView label)
	{
		label.Text = label.Text + "test";
	}
}
