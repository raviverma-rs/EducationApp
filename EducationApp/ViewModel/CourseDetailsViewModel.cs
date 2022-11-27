using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EducationApp.Models;
using EducationApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.ViewModel
{
    [QueryProperty("Course", "Course")]
    public partial class CourseDetailsViewModel : ObservableObject
    {
        public CourseDetailsViewModel()
        {
            
        }

        [ObservableProperty]
        CourseModel course;
    }
}
