﻿namespace MauiApp5;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("Settings");
    }
}

