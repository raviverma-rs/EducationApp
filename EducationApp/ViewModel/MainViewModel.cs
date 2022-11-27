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
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<CourseModel> items;

        public MainViewModel()
        {
            items = new ObservableCollection<CourseModel>
            {
                new CourseModel
                {
                    Index = 1,
                    SubTitle = "MVC Core",
                    Image = "mvc_core.png",
                    Description = "ASP.NET Core MVC is built on top of ASP.NET Core's routing, a powerful URL-mapping component that lets you build applications that have comprehensible and searchable URLs. This enables you to define your application's URL naming patterns that work well for search engine optimization (SEO) and for link generation, without regard for how the files on your web server are organized. You can define your routes using a convenient route template syntax that supports route value constraints, defaults and optional values."
                },

                new CourseModel
                {
                    Index = 2,
                    SubTitle = "Angular",
                    Image = "angular.png",
                    Description="Angular is an application-design framework and development platform for creating efficient and sophisticated single-page apps."
                },

                new CourseModel
                {
                    Index = 3,
                    SubTitle = "Javascript",
                    Image = "javascript.jpg",
                    Description = "JavaScript is the world's most popular programming language. JavaScript is the programming language of the Web."
                },

                new CourseModel
                {
                    Index = 4,
                    SubTitle = "Jquery",
                    Image = "jquery.png",
                    Description = "jQuery is a fast, small, and feature-rich JavaScript library. It makes things like HTML document traversal and manipulation, event handling, animation, and Ajax much simpler with an easy-to-use API that works across a multitude of browsers."
                },

                new CourseModel
                {
                    Index = 5,
                    SubTitle = "MAUI",
                    Image = "maui.png",
                    Description = ".NET MAUI is open-source and is the evolution of Xamarin.Forms, extended from mobile to desktop scenarios, with UI controls rebuilt from the ground up for performance and extensibility. If you've previously used Xamarin.Forms to build cross-platform user interfaces, you'll notice many similarities with .NET MAUI. However, there are also some differences. Using .NET MAUI, you can create multi-platform apps using a single project, but you can add platform-specific source code and resources if necessary."
                }
            };
        }

        [RelayCommand]
        public void Detail(CourseModel course)
        {
            Shell.Current.GoToAsync(nameof(DetailPage),true, 
                new Dictionary<string, object>
                {
                    { "Course", course }
                });
        }

    }
}
