﻿using EducationApp.ViewModel;

namespace EducationApp;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {

    }
}

