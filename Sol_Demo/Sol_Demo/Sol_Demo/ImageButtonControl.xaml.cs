using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageButtonControl : ContentView
    {
        public ImageButtonControl()
        {
            InitializeComponent();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, new Binding(nameof(Command), source: this));
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandParameterProperty, new Binding(nameof(CommandParameter), source: this));
            GestureRecognizers.Add(tapGestureRecognizer);
        }

        public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(ImageButtonControl));

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        public static readonly BindableProperty ButtonImageProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(ImageButtonControl));

        public string ImageSource
        {
            get => (string)GetValue(ButtonImageProperty);
            set => SetValue(ButtonImageProperty, value);
        }

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ImageButtonControl));

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ImageButtonControl), null);

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ImageButtonControl), null);

        public object CommandParameter
        {
            get => (object)GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }
    }
}