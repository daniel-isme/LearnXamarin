using LearnXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LearnXamarin.Views
{
    public class DetailPage : ContentPage
    {
        public DetailPage(DetailPageViewModel viewModel)
        {
            BindingContext = viewModel;

            Title = "Note Detail";

            BackgroundColor = Color.PowderBlue;

            var textLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            textLabel.SetBinding(Label.TextProperty, nameof(DetailPageViewModel.NoteText));

            var exitButton = new Button
            {
                Text = "Back",
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(20),
                BackgroundColor = Color.Red,
                TextColor = Color.White,
                FontSize = 20
            };
            exitButton.SetBinding(Button.CommandProperty, nameof(DetailPageViewModel.ExitCommand));

            var stackLayout = new StackLayout
            {
                Margin = new Thickness(20, 40)
            };
            stackLayout.Children.Add(textLabel);
            stackLayout.Children.Add(exitButton);

            Content = stackLayout;
        }
    }
}
