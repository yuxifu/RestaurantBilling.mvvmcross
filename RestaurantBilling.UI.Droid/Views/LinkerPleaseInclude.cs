using Android.Widget;

// This class is never actually executed, but when Xamarin linking is 
// enabled it does how to ensure types and properties are preserved 
// in the deployed app
// https://stackoverflow.com/questions/16924178/issues-with-mvvmcross-and-linking-on-android
// https://github.com/reactiveui/ReactiveUI/blob/rxui5-master/ReactiveUI.Platforms/Cocoa/Buildsupport/Linker.xml
// https://stackoverflow.com/questions/16924178/issues-with-mvvmcross-and-linking-on-android

public class LinkerIncludePlease
{
	private void IncludeButton(Button button)
	{
        button.Click += (s, e) => { };
        button.Enabled = !button.Enabled;
	}

	private void IncludeTextView(TextView tView)
	{
		tView.Text = tView.Text + "test";
	}

    private void IncludeEditText(EditText eText)
    {
        eText.AfterTextChanged += (sender, e) => {};
    }

	private void IncludeSeekBar(SeekBar sBar)
	{
        sBar.ProgressChanged += (sender, e) => {};
	}
}
