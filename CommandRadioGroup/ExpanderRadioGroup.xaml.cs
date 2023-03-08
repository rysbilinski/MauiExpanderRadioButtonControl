using CommunityToolkit.Mvvm.Input;

namespace CommandRadioGroup;

public partial class ExpanderRadioGroup : ContentView
{

    public static readonly BindableProperty IsExpandedInitiallyProperty =
        BindableProperty.Create(nameof(IsExpandedInitially), typeof(bool), typeof(View), false, BindingMode.OneWay);

    public bool IsExpandedInitially
    {
        get => (bool)GetValue(IsExpandedInitiallyProperty);
        set => SetValue(IsExpandedInitiallyProperty, value);
    }


    public static readonly BindableProperty HeaderTextProperty =
        BindableProperty.Create(nameof(HeaderText), typeof(string), typeof(View), null, BindingMode.TwoWay);

    public string HeaderText
    {
        get => (string)GetValue(HeaderTextProperty);
        set => SetValue(HeaderTextProperty, value);
    }


    public static readonly BindableProperty HeaderTextFontSizeProperty =
        BindableProperty.Create(nameof(HeaderTextFontSize), typeof(int), typeof(View), 14, BindingMode.TwoWay);

    public int HeaderTextFontSize
    {
        get => (int)GetValue(HeaderTextFontSizeProperty);
        set => SetValue(HeaderTextFontSizeProperty, value);
    }


    public static readonly BindableProperty HeaderTextColourProperty =
        BindableProperty.Create(nameof(HeaderTextColour), typeof(Color), typeof(View), Colors.Black, BindingMode.TwoWay);

    public Color HeaderTextColour
    {
        get => (Color)GetValue(HeaderTextColourProperty);
        set => SetValue(HeaderTextColourProperty, value);
    }


    public static readonly BindableProperty SelectedOptionFontIconProperty =
        BindableProperty.Create(nameof(SelectedOptionFontIcon), typeof(string), typeof(View), "x", BindingMode.TwoWay);

    public string SelectedOptionFontIcon
    {
        get => (string)GetValue(SelectedOptionFontIconProperty);
        set => SetValue(SelectedOptionFontIconProperty, value);
    }


    public static readonly BindableProperty UnselectedOptionFontIconProperty =
        BindableProperty.Create(nameof(UnselectedOptionFontIcon), typeof(string), typeof(View), "o", BindingMode.TwoWay);

    public string UnselectedOptionFontIcon
    {
        get => (string)GetValue(UnselectedOptionFontIconProperty);
        set => SetValue(UnselectedOptionFontIconProperty, value);
    }


    public static readonly BindableProperty FontIconFontFamilyProperty =
        BindableProperty.Create(nameof(FontIconFontFamily), typeof(string), typeof(View), null, BindingMode.TwoWay);

    public string FontIconFontFamily
    {
        get => (string)GetValue(FontIconFontFamilyProperty);
        set => SetValue(FontIconFontFamilyProperty, value);
    }


    public static readonly BindableProperty SelectedOptionFontIconTextColourProperty =
        BindableProperty.Create(nameof(SelectedOptionFontIconTextColour), typeof(object), typeof(View), Colors.Red, BindingMode.TwoWay);

    public object SelectedOptionFontIconTextColour
    {
        get => (object)GetValue(SelectedOptionFontIconTextColourProperty);
        set => SetValue(SelectedOptionFontIconTextColourProperty, value);
    }




    public static readonly BindableProperty SelectedOptionProperty =
        BindableProperty.Create(nameof(SelectedOption), typeof(object), typeof(View), null, BindingMode.TwoWay);

    public object SelectedOption
    {
        get => (object)GetValue(SelectedOptionProperty);
        set => SetValue(SelectedOptionProperty, value);
    }


    public static readonly BindableProperty SelectedTextProperty =
        BindableProperty.Create(nameof(SelectedText), typeof(string), typeof(View), null, BindingMode.TwoWay);

    public string SelectedText
    {
        get => (string)GetValue(SelectedTextProperty);
        set => SetValue(SelectedTextProperty, value);
    }



    public static readonly BindableProperty ItemSourceProperty =
        BindableProperty.Create(nameof(ItemSource), typeof(Dictionary<string, object>), typeof(View), new Dictionary<string, object> { { "Test", "hi there" },{ "Test 2", false } }, BindingMode.TwoWay);

    public Dictionary<string, object> ItemSource
    {
        get => (Dictionary<string, object>)GetValue(ItemSourceProperty);
        set => SetValue(ItemSourceProperty, value);
    }


    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
                                    propertyName: nameof(Command),
                                    returnType: typeof(RelayCommand),
                                    declaringType: typeof(View),
                                    defaultValue: null,
                                    defaultBindingMode: BindingMode.TwoWay);

    public RelayCommand Command
    {
        get { return (RelayCommand)GetValue(CommandProperty); }
        set { SetValue(CommandProperty, value); }
    }

    public RelayCommand<KeyValuePair<string, object>> SelectedItemCommand => new RelayCommand<KeyValuePair<string, object>>((s) =>
    {
        this.SelectedOption = s.Value;
        this.SelectedText = s.Key;
        this.expander.IsExpanded = false;
        this.OnPropertyChanged(nameof(SelectedOption));        
    });

    public ExpanderRadioGroup()
	{
		InitializeComponent();
	}
}