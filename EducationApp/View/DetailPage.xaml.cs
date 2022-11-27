using EducationApp.Models;
using EducationApp.ViewModel;

namespace EducationApp.View;

public partial class DetailPage : ContentPage
{
    public DetailPage(CourseDetailsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}